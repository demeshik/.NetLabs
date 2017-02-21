using System;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace laba10
{
    public partial class ModalForm : Form
    {
        public ModalForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Car.Color = color.Text;
            Car.Name = name.Text;
            Car.Value = value.Text;
            Car.Year = year.Text;
            Car.Number = number.Text;
            if (color.Text != string.Empty)
            {
                Car.modifNames.Add("Color");
                Car.modifValues.Add(Car.Color);
            }
            if (name.Text != string.Empty)
            {
                Car.modifNames.Add("Model");
                Car.modifValues.Add(Car.Name);
            }
            if (value.Text != string.Empty)
            {
                Car.modifNames.Add("Value");
                Car.modifValues.Add(Car.Value);
            }
            if (year.Text != string.Empty)
            {
                Car.modifNames.Add("Year");
                Car.modifValues.Add(Car.Year);
            }
            if (number.Text != string.Empty)
            {
                Car.modifNames.Add("Number");
                Car.modifValues.Add(Car.Number);
            }
            if (Car.Image != null)
            {
                Car.modifNames.Add("Image");
                Car.modifValues.Add(Car.Image);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Image rs = Image.FromFile(openFileDialog1.FileName);
                Car.Image = rs;
            }
        }
    }
}
