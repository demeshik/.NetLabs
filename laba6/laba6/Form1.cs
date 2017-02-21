using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace laba6
{
    public partial class Form1 : Form
    {
        List<Person> List = new List<Person>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            favColor.ShowDialog();
            pictureBox1.BackColor = favColor.Color;
        }

        private void Clear()
        {
            name.Clear();
            birthday.Value = DateTime.Today;
            favColor.Color = Color.White;
            pictureBox1.BackColor = DefaultBackColor;
            favFont.Font = new Font("Microsoft Sans Serif", 10);
            exampleFont.Font = favFont.Font;
            about.Clear();
            browser.SelectedItem = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            favFont.ShowDialog();
            exampleFont.Font = favFont.Font;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Person temp = new Person();
            temp.About = about.Text;
            temp.Browser = browser.SelectedItem.ToString();
            temp.Color = favColor.Color.Name;
            temp.Date = birthday.Value.ToString();
            temp.Font = favFont.Font.FontFamily.Name;
            temp.Name = name.Text;
            List.Add(temp);
            MessageBox.Show("Данные успешно сохранены.");
            Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //DateTimeConverter dateConv = new DateTimeConverter();
            //ColorConverter colorConv = new ColorConverter();
            //progressBar1.Visible = true;
            //progressBar1.Minimum = 1;
            //progressBar1.Maximum = 25;
            //progressBar1.Value = 1;
            //progressBar1.Step = 1;
            List<Person> tmp = Deserializer.Deserialize();
            if (tmp == null)
                MessageBox.Show("Возникла проблема с открытием файла.");
            //if (tmp.Count == 1)
            //{
            //    person = tmp[0];
            //    for (int x = 1; x <= 27; x++)
            //    {
            //        Thread.Sleep(200);
            //        progressBar1.PerformStep();
            //    }
            //    progressBar1.Hide();
            //    name.Text = person.Name;
            //    birthday.Value = (DateTime)dateConv.ConvertFromString(person.Date);
            //    favColor.Color = (Color)colorConv.ConvertFromString(person.Color);
            //    pictureBox1.BackColor = favColor.Color;
            //    favFont.Font = new Font(person.Font, 10);
            //    exampleFont.Font = favFont.Font;
            //    about.Text = person.About;
            //    foreach (var s in browser.Items)
            //    {
            //        if (s.ToString() == person.Browser)
            //            browser.SelectedItem = s;
            //    }
            //}
            //else
            //{
            Exec temp = new Exec();
            temp.execListB.Items.Clear();
            for (int i = 0; i < tmp.Count; i++)
                temp.execListB.Items.Add(tmp[i]);
            temp.Show();
            //}

        }
        private void saveFile(object sender, EventArgs e)
        {
            MessageBox.Show("Данные успешно сохранены в файл.");
            Serializer.Serialize(List);
        }
    }
}
