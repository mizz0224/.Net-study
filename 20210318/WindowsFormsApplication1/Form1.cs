using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        private string score;
        private int count_all = 0;
        private int count_collect = 0;
        private char ch = ' ';
        private int timer = 0;
        private int x;
        private int y;
        private int speed = 300;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Timer T = new Timer();
            T.Interval = 1000;
            T.Tick += new EventHandler(Form1_Timer);
            T.Start();
            x = ClientRectangle.Width / 2;
            ch = Convert.ToChar(random.Next('a', 'z' + 1));
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == ch)
            {
                
                count_collect++;
            }
            reset();
        }
        private void Form1_Timer(object sender, System.EventArgs e)
        {
            timer++;
            y += speed;
            if(y>=ClientRectangle.Width)
            {
                reset();
            }
            Invalidate();
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            string printscore = "총 문자수 : " + count_all + "\n" + "맞은 문자수 : " + count_collect;
            e.Graphics.DrawString(printscore, this.Font, Brushes.Black, 10, 10);
            e.Graphics.DrawString(ch.ToString(), this.Font, Brushes.Black, x, y);
            
        }
        private void reset()
        {
            ch = Convert.ToChar(random.Next('a', 'z' + 1));
            count_all++;
            x = ClientRectangle.Width / 2;
            y = 10;
            Invalidate();
        }
    }
}
