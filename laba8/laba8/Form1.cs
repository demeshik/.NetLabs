using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;

namespace laba8
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        private static extern IntPtr LoadCursorFromFile(string path);
        public int number = 1;
        public Form1()
        {
            this.Cursor = new Cursor(LoadCursorFromFile(@"C:\Users\djraz\Downloads\dmz\dmz-neon-red\dmz-neon-red-arrow.cur"));
            InitializeComponent();
            this.AllowDrop = true; 
        }

        private void каскадноеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void вертикальноеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void горизонтальноеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void новоеОкноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MDIChild x = new MDIChild();
            x.MdiParent = this;
            x.Text = "Безымянный" + number;
            number++;
            x.Show();
        }

        private void оПрограммеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Многодокументный текстовый редактор v2.0\n\nДемещик А.С.");
        }

        private void открытьФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Filter = "Текстовый документ (*.txt)|*.txt|Все файлы (*.*)|*.*";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    MDIChild x = new MDIChild();
                    x.MdiParent = this;
                    x.Text = openFileDialog1.FileName;
                    x.richTextBox1.Text = File.ReadAllText(openFileDialog1.FileName);
                    x.Show();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void русскаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("");
            this.Controls.Clear();
            InitializeComponent();
        }

        private void английскаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-001");
            this.Controls.Clear();
            InitializeComponent();
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop) &&
                ((e.AllowedEffect & DragDropEffects.Move) == DragDropEffects.Move))
                e.Effect = DragDropEffects.Move;
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                if (MessageBox.Show("Вы действительно хотите открыть этот файл?", "Предупреждение", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    if (e.Data.GetDataPresent(DataFormats.FileDrop) && e.Effect == DragDropEffects.Move)
                    {
                        string[] FileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);
                        MDIChild x = new MDIChild();
                        x.MdiParent = this;
                        x.richTextBox1.Text += File.ReadAllText(FileList[0]);
                        x.Text = FileList[0];
                        x.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
