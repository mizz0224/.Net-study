using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace 첫수업
{
    public partial class Form1 : Form
    {

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        ArrayList ar;

        public Form1()
        {
            InitializeComponent();
            ar = new ArrayList();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Random Random = new Random();
            if (e.Button == (MouseButtons)(1048576))
            {
                CMyData c = new CMyData();
                c.Shape = (int)Random.Next(2);
                c.Size = (int)Random.Next(50, 200);
                c.Point = new Point(e.X, e.Y);
                c.bColor = Color.FromArgb(Random.Next(256), Random.Next(256), Random.Next(256));
                c.pColor = Color.FromArgb(Random.Next(256), Random.Next(256), Random.Next(256));
                ar.Add(c);
            }
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            foreach (CMyData c in ar)
            {
                SolidBrush brc = new SolidBrush(c.bColor);
                Pen p = new Pen(c.pColor);

                Graphics G = e.Graphics;

                G.DrawEllipse(p, c.Point.X, c.Point.Y,50,50);
                G.FillEllipse(brc, c.Point.X, c.Point.Y,50,50);
                
               
            }
        }

    }
    public class CMyData
    {
        private Point point;
        //private Color penCol;
        private Color brushCol;
        private int size, shape;

        //public int X { get; }
        public Color pColor
        {
            get;
            set;
        } // 밑과 동일하게 동작

        public Color bColor
        {
            get { return brushCol; }
            set { brushCol = value; }
        }

        public Point Point
        {
            get { return point; }
            set { point = value; }
        }

        public int Size
        {
            get { return size; }
            set { size = value; }
        }

        public int Shape
        {
            get { return shape; }
            set { shape = value; }
        }

    }

}
