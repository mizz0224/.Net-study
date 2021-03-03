using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; // .Net Framework 활용 
using System.Collections; //  상동
namespace _1주차_1
{
    public partial class Form1 : Form // : <-상속받는다 즉 Form1이 Form을 상속받는다 , Form1 은 api할때 caption 이라 보면됨
    {
        ArrayList ar;
        public Form1()
        {
            InitializeComponent();
            ar = new ArrayList();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Random Random = new Random();
            if(e.Button == MouseButtons.Left)
            {
                CMyData c = new CMyData();
                c.Shape = (int)Random.Next(2);
                c.Size = (int)Random.Next(50, 200);
                c.Half = c.Size / 2;
                c.Point = new Point(e.X-c.Half, e.Y-c.Half);
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
                if(c.Shape == 1)
                {
                    e.Graphics.DrawEllipse(p, c.Point.X, c.Point.Y, c.Size, c.Size);
                    e.Graphics.FillEllipse(brc, c.Point.X, c.Point.Y, c.Size, c.Size);

                }
                else
                {
                    e.Graphics.DrawRectangle(p, c.Point.X, c.Point.Y, c.Size, c.Size);
                    e.Graphics.FillRectangle(brc, c.Point.X, c.Point.Y, c.Size, c.Size);

                }

            }
        }
        public class CMyData
        {
            private Point point;
            private Color penCol;
            private Color brushCol;
            private int size, shape,half;
            
            public Color pColor
            {
                get { return penCol;}
                set { penCol = value;}
            }
            public Color bColor
            {
                get { return penCol; }
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
            public int Half
            {
                get { return half; }
                set { half = value; }
            }
            public int Shape
            {
                get { return shape; }
                set { shape = value; }
            }

        }
        
    }
}
