using System;
using lab4;
using laba_1;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba5_2
{
    public partial class Form1 : Form
    {
        Form secondForm = new Form();
        ListBox listb = new ListBox();
        ListBox zapist = new ListBox();
        Pyramid tempPyr = new Pyramid();
        List<Pyramid> list = new List<Pyramid>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            Form secondForm = new Form();
            secondForm.Width = 500;
            secondForm.Height = 500;

            Button vozvrSort = new Button();
            Button ubyvSort = new Button();
            Button zapros1 = new Button();
            Button zapros2 = new Button();
            Button zapros3 = new Button();
            vozvrSort.Left = 125;
            vozvrSort.Top = 150;
            vozvrSort.Width = 100;
            vozvrSort.Text = "Возрастающая";
            
            ubyvSort.Left = 275;
            ubyvSort.Top = 150;
            ubyvSort.Width = 100;
            ubyvSort.Text = "Убывающая";

            zapros1.Left = 50;
            zapros1.Top = 200;
            zapros1.Width = 100;
            zapros1.Text = "Максимальный элемент";

            zapros2.Left = 200;
            zapros2.Top = 200;
            zapros2.Width = 100;
            zapros2.Text = "Минимальный элемент";

            zapros3.Left = 350;
            zapros3.Top = 200;
            zapros3.Width = 100;
            zapros3.Text = "С равным параметру";

            ubyvSort.Click += UbyvSort_Click;
            vozvrSort.Click += But_Click;
            zapros1.Click += Zapros1_Click;
            zapros2.Click += Zapros2_Click;
            zapros3.Click += Zapros3_Click;

            for (int i = 0; i < Int32.Parse(number.Text); i++)
            {
                Pyramid temp = new Pyramid(rand.Next(Int32.Parse(heightFrom.Text), Int32.Parse(heightTo.Text)),
                    rand.Next(Int32.Parse(perimetrFrom.Text), Int32.Parse(perimetrTo.Text)),
                    rand.Next(Int32.Parse(squareFrom.Text), Int32.Parse(squareTo.Text)));
                list.Add(temp);
                listb.Items.Add(temp);
            }
            listb.Width = 350;
            listb.Left = 75;
            zapist.Width = 350;
            zapist.Left = 75;
            zapist.Top = 300;
            secondForm.Controls.Add(listb);
            secondForm.Controls.Add(zapist);
            secondForm.Controls.Add(vozvrSort);
            secondForm.Controls.Add(ubyvSort);
            secondForm.Controls.Add(zapros1);
            secondForm.Controls.Add(zapros2);
            secondForm.Controls.Add(zapros3);
            secondForm.Show();
        }

        private void Zapros3_Click(object sender, EventArgs e)
        {
            var sen = from n in list
                      where n._Height == 5
                      select n;
            if (sen == null)
            {
                string t = "Sorry, no";
                zapist.Items.Clear();
                zapist.Items.Add(t);
            }
            else
            {
                zapist.Items.Clear();
                foreach(var x in sen)
                {
                    zapist.Items.Add(x);
                }
            }
        }

        private void Zapros2_Click(object sender, EventArgs e)
        {
            //Pyramid tp = new Pyramid();
            //foreach(var x in zapist.Items)
            //{
            //    Pyramid tmp = x as Pyramid;
            //    if (tmp != null)
            //        if (tmp.Id == temp)
            //            tp = tmp;
            //}
            var temp = list.Min(a => a.Id);
            zapist.Items.Clear();
            string tmp = $"Min Id in the List is = {temp}";
            zapist.Items.Add(tmp);
        }

        private void Zapros1_Click(object sender, EventArgs e)
        {
            var temp = list.Max(a => a.Id);
            string tmp = $"Max Id in the List is = {temp}";
            zapist.Items.Clear();
            zapist.Items.Add(tmp);
        }

        private void UbyvSort_Click(object sender, EventArgs e)
        {
            list.Sort((first, second) => second.Id.CompareTo(first.Id));
            listb.Items.Clear();
            foreach (var x in list)
                listb.Items.Add(x);
        }

        private void But_Click(object sender, EventArgs e)
        {
            list.Sort();
            listb.Items.Clear();
            foreach (var x in list)
                listb.Items.Add(x);
        }
    }
}
