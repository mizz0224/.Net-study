using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Curve
{
    class CMyData
    {
        private Color color;
        private double width;
        public ArrayList Ar;

        public CMyData()  //생성자함수
        {
            Ar = new ArrayList();
        }
        public Color Color
        {
            get { return color; }
            set { color = value; }
        }
        public double Width
        {
            get { return width; }
            set { width = value; }
        }
        public ArrayList AR
        {
            get { return Ar; }
        }
    }
	public partial class Form1 : Form
	{
		private int x, y;
        private LinkedList<ArrayList> total_lines;
        private ArrayList ar;
        private Color currentcolor = Color.Black;
        private double currentwidth = 1.0;

		public Form1()
		{
            total_lines = new LinkedList<ArrayList>();
			InitializeComponent();
		}

		private void Form1_MouseDown(object sender, MouseEventArgs e)
		{
            CMyData c = new CMyData();
            c.Color = currentcolor;
            c.Width = currentwidth;
            c.AR.Add(c.Color);
            c.AR.Add(c.Width);
			if (e.Button == MouseButtons.Left)
			{
				x = e.X;
				y = e.Y;
                ar = new ArrayList();
                ar.Add(new Point(x, y));
                ar.Add(c.AR);
			}
		}

		private void Form1_MouseMove(object sender, MouseEventArgs e)
		{
			if (Capture && e.Button == MouseButtons.Left)
			{
				Graphics G = CreateGraphics();
                Pen p = new Pen(currentcolor,currentwidth);
				G.DrawLine(p, x, y, e.X, e.Y);
				x = e.X;
				y = e.Y;
                ar.Add(new Point(x, y));
				G.Dispose();
			}
		}


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            foreach (ArrayList line in total_lines)
            {
                Pens p = new Pen(line.AR.);
                for (int i = 1; i < line.Count; i++)
                {
                    e.Graphics.DrawLine(Pens.Black, (Point)line[i - 1], (Point)line[i]);
                }
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            total_lines.AddLast(ar);
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {

        }
	}
}
