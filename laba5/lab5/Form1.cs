using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5
{
    public partial class Калькулятор : Form
    {
        public Калькулятор()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e){}
        private void textBox2_TextChanged(object sender, EventArgs e){}
        private void textBox7_TextChanged(object sender, EventArgs e){}

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CharConverter a = new CharConverter();
                char operand = (char)a.ConvertFromString(comboBox1.SelectedItem.ToString());
                switch(operand)
                {
                    case '+':
                        {
                            string s1 = textBox1.Text;
                            string s2 = textBox2.Text;
                            textBox7.Text = s1 + s2;
                        } break;
                    case '-':
                        {
                            string s1 = textBox1.Text;
                            string s2 = textBox2.Text;
                            textBox7.Text = s1.Replace(s2, "");
                        } break;
                    case '*':
                        {
                            string s1 = textBox1.Text;
                            string s2 = textBox2.Text;
                            Random rs = new Random();
                            textBox7.Text = s1.Insert(rs.Next(0, s1.Length), s2);
                        } break;
                    case '/':
                        {
                            string s1 = textBox1.Text;
                            string s2 = textBox2.Text;
                            Random rs = new Random();
                            int startPos = 0, length = 0, temp = -1;
                            while (temp <= 0) 
                            { 
                                startPos = rs.Next(0, s1.Length);
                                length = startPos + s2.Length;
                                temp = s1.Length - length;
                                
                            }
                            textBox7.Text = s1.Remove(startPos, s2.Length);
                        } break;
                }
            }
        }
    }
}
