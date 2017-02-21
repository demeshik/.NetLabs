using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace laba6
{
    public partial class Exec : Form
    {
        public Exec()
        {
            InitializeComponent();
        }
        private void Exec_Load(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToString() + ";";
            objCount.Text = execListB.Items.Count.ToString();
        }
        public bool matcher;

        public IEnumerable<XElement> order(string param, object equalParam)
        {
            IEnumerable<XElement> ord = null;
            XDocument xdoc = XDocument.Load("pers.xml");
            try
            {
                if (equalParam == null)
                {
                    ord = from t in xdoc.Root.Elements("Person")
                          let name = t.Element(param).Value
                          orderby name
                          select t;
                }
                else
                {
                    string equalp = (string)equalParam;
                    ord = from t in xdoc.Root.Elements("Person")
                          where t.Element(param).Value == equalp
                          select t;
                }
            }
            catch(XmlException error)
            {
                MessageBox.Show(error.Message);
            }
            return ord;
        }
        public IEnumerable<XElement> regSearch(string p)
        {
            IEnumerable<XElement> or = null;
            XDocument doc = XDocument.Load("pers.xml");
            Regex reg = new Regex(valRegSearch.Text, RegexOptions.IgnoreCase);

            or = from t in doc.Root.Elements("Person")
                 let s = reg.IsMatch(t.Element(p).Value)
                 where s == true
                 select t;

            return or;
        }

        public void InsertData(ListBox list, IEnumerable<XElement> temper)
        {
            list.Items.Clear();
            foreach (XElement dor in temper)
            {
                Person temp = new Person();
                temp.Name = dor.Element("Name").Value;
                temp.Color = dor.Element("Color").Value;
                temp.Date = dor.Element("Date").Value;
                temp.About = dor.Element("About").Value;
                temp.Font = dor.Element("Font").Value;
                temp.Browser = dor.Element("Browser").Value;
                list.Items.Add(temp);
            }
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Anko, v2.0. \nДемещик А.С.", "О программе");
        }
        private void имяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IEnumerable<XElement> orde = order("Name", null);
            InsertData(execListB, orde);
        }
        private void датаРожденияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IEnumerable<XElement> orde = order("Date", null);
            InsertData(execListB, orde);
        }
        private void поИмениToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textSearch.Visible = Visible;
            valSearch.Visible = Visible;
            valSearch.Clear();
            label1.Text = "Имя: ";
            label1.Visible = Visible;
            label2.Visible = Visible;
            button1.Visible = Visible;
            faqReg.Visible = Visible;
            regLabel.Visible = Visible;
            valRegSearch.Visible = Visible;
            valRegSearch.Clear();
            matcher = true;
        }
        private void поЦветуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textSearch.Visible = Visible;
            valSearch.Visible = Visible;
            valSearch.Clear();
            label1.Text = "Цвет: ";
            label1.Visible = Visible;
            label2.Visible = Visible;
            button1.Visible = Visible;
            regLabel.Visible = Visible;
            faqReg.Visible = Visible;
            valRegSearch.Visible = Visible;
            valRegSearch.Clear();
            matcher = false;
        }

        private void searchButton(object sender, EventArgs e)
        {
            string temper = valSearch.Text;
            if (temper == String.Empty)
            {
                if(matcher)
                    InsertData(rezultList, regSearch("Name"));
                else
                    InsertData(rezultList, regSearch("Color"));
                rezultList.Visible = Visible;
                return;
            }
            if (matcher)
            {
                IEnumerable<XElement> t = order("Name", temper);
                InsertData(rezultList, t);
                rezultList.Visible = Visible;
            }
            else
            {
                IEnumerable<XElement> t = order("Color", temper);
                InsertData(rezultList, t);
                rezultList.Visible = Visible;
            }
        }

        private void fAQToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string content = "Программа устроена таким образом, что\nв случае, если и поле значения поиска\nи регулярное выражение заданы\nпоиск будет выполнен по имени.\n\nПомощь по регулярным выражениям:\n\ntemp$ - поиск слов, кончающихся temp\n^temp - поиск слов, начинающихся на temp.";
            MessageBox.Show(content, "F.A.Q.");
        }

        private void faqReg_Click(object sender, EventArgs e)
        {
            string content = "Помощь по регулярным выражениям:\n\ntemp$ - поиск слов, кончающихся temp\n^temp - поиск слов, начинающихся на temp.";
            MessageBox.Show(content, "F.A.Q.");
        }
    }
}
