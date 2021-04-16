using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace MouseDown
{
	public partial class Form1 : Form
	{
		private ArrayList ar;
		public Form1()
		{
            
			ar = new ArrayList();
			InitializeComponent();
		}

		private void Form1_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ar.Add(new Point(e.X, e.Y));
                
				Invalidate();
			}
		}

		private void Form1_Paint(object sender, PaintEventArgs e)
		{
			foreach (Point p in ar)
			{
                int size = 50;
                e.Graphics.FillEllipse(Brushes.Black, p.X - size / 2, p.Y - size / 2, size, size);
                e.Graphics.DrawEllipse(new Pen(Color.Red, 3), p.X - size / 2, p.Y - size / 2, size, size);
                //순서바꾸기전에는 테두리가 안예뻣는데 위에처럼 순서바꾸면 조금 나아짐 ㅋㅋ
			}
		}

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
        }
	}
}
