using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;


namespace laba10
{
    public partial class Form1 : Form
    {
        MySqlConnectionStringBuilder connectionString = new MySqlConnectionStringBuilder();
        DataGridViewRow row = null;
        public Form1()
        {
            connectionString.Server = "MYSQL5017.Smarterasp.net";
            connectionString.Database = "db_9ff283_brb";
            connectionString.UserID = "9ff283_brb";
            connectionString.Password = "MyDearNastya15";
            connectionString.ConnectionTimeout = 60;
            connectionString.SslMode = MySqlSslMode.None;
            connectionString.CharacterSet = "utf8";
            InitializeComponent();
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModalForm x = new ModalForm();
            x.Owner = this;
            if (x.ShowDialog() == DialogResult.OK)
            {
                ImageConverter convertor = new ImageConverter();
                byte[] imageFile = (byte[])convertor.ConvertTo(Car.Image, typeof(byte[]));
                string query = $@"insert into cars(Name, Color, Year, Value, Number, Image) values('{Car.Name}','{Car.Color}','{Car.Year}','{Car.Value}','{Car.Number}',?imageFile);";
                MySqlParameter filecontent = new MySqlParameter("?imageFile", MySqlDbType.LongBlob, imageFile.Length);
                filecontent.Value = imageFile;
                using (MySqlConnection connect = new MySqlConnection())
                {
                    connect.ConnectionString = connectionString.ConnectionString;
                    MySqlCommand comm = new MySqlCommand(query, connect);
                    comm.Parameters.Add(filecontent);
                    try
                    {
                        connect.Open();
                        comm.ExecuteNonQuery();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            string query = @"select * from cars";
            using (MySqlConnection connect = new MySqlConnection())
            {
                connect.ConnectionString = connectionString.ConnectionString;
                MySqlCommand command = new MySqlCommand(query, connect);
                try
                {
                    connect.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    this.dataGridView1.Columns.Add("name", "Name");
                    this.dataGridView1.Columns["name"].Width = 100;
                    this.dataGridView1.Columns.Add("color", "Color");
                    this.dataGridView1.Columns["color"].Width = 100;
                    this.dataGridView1.Columns.Add("year", "Year");
                    this.dataGridView1.Columns["year"].Width = 100;
                    this.dataGridView1.Columns.Add("value", "Value");
                    this.dataGridView1.Columns["value"].Width = 100;
                    this.dataGridView1.Columns.Add("number", "Number");
                    this.dataGridView1.Columns["number"].Width = 100;
                    this.dataGridView1.Columns.Add("photo", "Photo");
                    this.dataGridView1.Columns["photo"].Width = 100;
                    while (reader.Read())
                    {
                        this.dataGridView1.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5]);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = $@"delete from cars where Model = '{row.Cells[0].Value.ToString()}'";
            using (MySqlConnection connect = new MySqlConnection())
            {
                connect.ConnectionString = connectionString.ConnectionString;
                MySqlCommand command = new MySqlCommand(query, connect);
                try
                {
                    connect.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            MessageBox.Show("Строка удалена, обновите таблицу");
        }

        private void dataGridView1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged == DataGridViewElementStates.Selected)
            {
                row = e.Row;
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (row.Cells[5].Value == null)
            {
                MessageBox.Show("Фотографий нет");
            }
            else
            {
                MemoryStream ms = new MemoryStream((byte[])row.Cells[5].Value);
                ImageForm x = new ImageForm();
                x.pictureBox1.Image = Image.FromStream(ms);
                x.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Car.Clear();
            Car.modifNames.Clear();
            Car.modifValues.Clear();
            ModalForm x = new ModalForm();
            x.Owner = this;
            string queryString = "update cars set ";
            List<MySqlParameter> parametrs = new List<MySqlParameter>();
            if (x.ShowDialog() == DialogResult.OK)
            {
                foreach(var s in Car.modifNames)
                {
                    queryString += s + $" = ?{s}, ";
                    MySqlParameter parameter = new MySqlParameter();
                    parameter.ParameterName = "?" + s;
                    if (s == "Year")
                        parameter.MySqlDbType = MySqlDbType.Year;
                    else if (s == "Image")
                    {
                        parameter.MySqlDbType = MySqlDbType.LongBlob;
                    }
                    else
                        parameter.MySqlDbType = MySqlDbType.VarChar;
                    parametrs.Add(parameter);
                }
                queryString = queryString.Remove(queryString.Length - 2, 2);
                queryString += $" where Name = '{row.Cells[0].Value.ToString()}';";

                ImageConverter convertor = null;
                byte[] imageFile;
                for (int i = 0; i < parametrs.Count; i++) 
                {
                    if (parametrs[i].ParameterName == "?Image")
                    {
                        convertor = new ImageConverter();
                        imageFile = (byte[])convertor.ConvertTo(Car.modifValues[i], typeof(byte[]));
                        parametrs[i].Size = imageFile.Length;
                        parametrs[i].Value = imageFile;
                    }
                    else
                        parametrs[i].Value = Car.modifValues[i].ToString();
                }

                using (MySqlConnection connect = new MySqlConnection())
                {
                    connect.ConnectionString = connectionString.ConnectionString;
                    MySqlCommand comm = new MySqlCommand(queryString, connect);
                    foreach (var param in parametrs)
                        comm.Parameters.Add(param);
                    comm.CommandTimeout = 60;
                    try
                    {
                        connect.Open();
                        comm.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                MessageBox.Show("Информация изменена, обновите таблицу.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Sort(this.dataGridView1.Columns[0], ListSortDirection.Ascending);
            MessageBox.Show("Таблица отсортирована");

        }
    }
}
