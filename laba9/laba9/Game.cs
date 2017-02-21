using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba9
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }
        public void drawRect(Graphics dc, Brush br, Rectangle rect)
        {
            dc.FillRectangle(br, rect);
            
        }
        public void drawEll(Graphics dc, Brush br, Rectangle rect)
        {
            dc.FillEllipse(br, rect);

        }
        public void drawTreug(Graphics dc, Brush br, Point[] mas)
        {
            byte[] masa = { (byte)PathPointType.Start, (byte)PathPointType.Line, (byte)PathPointType.Line };
            GraphicsPath s = new GraphicsPath(mas, masa);
            dc.FillPath(br, s);
        }
        public void Drawing()
        {
            Graphics dc = CreateGraphics();
            drawRect(dc, new HatchBrush(HatchStyle.DiagonalCross, Color.Red, Color.White), new Rectangle(10, 10, 50, 50));
            drawEll(dc, new HatchBrush(HatchStyle.DiagonalBrick, Color.Blue, Color.White), new Rectangle(65, 10, 50, 50));
            Point[] mas = { new Point(145,10), new Point(120,60), new Point(170,60) };
            drawTreug(dc, new HatchBrush(HatchStyle.DiagonalCross, Color.Green, Color.White), mas);

            drawEll(dc, new HatchBrush(HatchStyle.DiagonalCross, Color.Green, Color.White), new Rectangle(10, 65, 50, 50));
            Point[] masa = { new Point(90, 65), new Point(65, 115), new Point(115, 115) };
            drawTreug(dc, new HatchBrush(HatchStyle.DiagonalCross, Color.Blue, Color.White), masa);
            drawRect(dc, new HatchBrush(HatchStyle.Divot, Color.Green, Color.White), new Rectangle(120, 65, 50, 50));

            Point[] masaa = { new Point(35, 120), new Point(10, 170), new Point(60, 170) };
            drawTreug(dc, new HatchBrush(HatchStyle.Divot, Color.Red, Color.White), masaa);
            drawRect(dc, new HatchBrush(HatchStyle.DiagonalBrick, Color.Blue, Color.White), new Rectangle(65, 120, 50, 50));

            drawRect(dc, new HatchBrush(HatchStyle.Divot, Color.Green, Color.White), new Rectangle(380, 90, 50, 50));
            drawEll(dc, new HatchBrush(HatchStyle.Divot, Color.Red, Color.White), new Rectangle(380, 150, 50, 50));
            Point[] masaaa = { new Point(405, 205), new Point(380, 255), new Point(430, 255) };
            drawTreug(dc, new HatchBrush(HatchStyle.Divot, Color.Red, Color.White), masaaa);

        }

        private void Game_Paint(object sender, PaintEventArgs e)
        {
            Drawing();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                MessageBox.Show("Неверно!");
            if (radioButton3.Checked)
                MessageBox.Show("Неверно!");
            if (radioButton2.Checked)
            {
                Graphics dc = CreateGraphics();
                drawEll(dc, new HatchBrush(HatchStyle.Divot, Color.Red, Color.White), new Rectangle(120, 120, 50, 50));
                MessageBox.Show("Верно!");
            }

        }
    }
}
