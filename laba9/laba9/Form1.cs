using System;
using System.Drawing;
using System.Windows.Forms;
using ZedGraph;

namespace laba9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double f(double x)
        {
            return 1 / (Math.Pow(x, 2) - 5);
        }

        public void Draw()
        {
            LineItem curve = null;
            BarItem bar = null;
            GraphPane pane = this.zedGraphControl1.GraphPane;
            pane.CurveList.Clear();
            PointPairList list = new PointPairList();
            double xmin = GraphSettings.minX;
            double xmax = GraphSettings.maxX;

            for (double x = xmin; x <= xmax; x = x + GraphSettings.dX)
                list.Add(x, f(x));

            if (String.Equals(GraphSettings.graphType, "Graphic"))
                curve = pane.AddCurve("Simple", list, GraphSettings.graphColor, SymbolType.Circle);
            else
                bar = pane.AddBar("Simple", list, GraphSettings.graphColor);
            pane.Title.Text = $"y(x) = {GraphSettings.aVal}*x^3 + {GraphSettings.bVal}*x^2 + {GraphSettings.cVal}*x + {GraphSettings.dVal}";
            pane.XAxis.Title = (new AxisLabel("X", "Arial", 16, Color.Black, true, false, false));
            pane.YAxis.Title = (new AxisLabel("Y", "Arial", 16, Color.Black, true, false, false));
            pane.Legend.FontSpec = (new FontSpec("Monotype Corsiva", 16, Color.Blue, true, false, false));
            zedGraphControl1.AxisChange();
            zedGraphControl1.Invalidate();
            zedGraphControl1.Visible = Visible;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Modal md = new Modal();
            md.Owner = this;
            if (md.ShowDialog() == DialogResult.OK)
                Draw();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Game game = new Game();
            game.Drawing();
            game.Show();
        }
    }
}
