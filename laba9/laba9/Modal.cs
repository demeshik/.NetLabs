using System;
using System.Windows.Forms;

namespace laba9
{
    public partial class Modal : Form
    {
        public Modal()
        {
            InitializeComponent();
        }

        private void colorBut_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
        }

        public void finishBut_Click(object sender, EventArgs e)
        {
            try
            {
                GraphSettings.aVal = Double.Parse(aval.Text);
                GraphSettings.bVal = Double.Parse(bval.Text);
                GraphSettings.cVal = Double.Parse(cval.Text);
                GraphSettings.dVal = Double.Parse(dval.Text);
                GraphSettings.graphColor = colorDialog1.Color;
                GraphSettings.minX = Double.Parse(minX.Text);
                GraphSettings.maxX = Double.Parse(maxX.Text);
                GraphSettings.dX = Double.Parse(dX.Text);
                GraphSettings.graphType = graphType.SelectedItem.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Заполните все поля и попробуйте еще раз!");
                this.Close();
                this.Owner.Close();
            }
            
        }
    }
}
