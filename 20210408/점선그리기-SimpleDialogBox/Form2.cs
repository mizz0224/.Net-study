using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace mixControl
{
    public partial class Form2 : Form
    {
        //private int iDialogShape;
        private Color Pencolor;
        public Color Pcolor
        {
            get {
                if (radioButton1.Checked) Pencolor = Color.FromArgb(255, 0, 0);
                if (radioButton2.Checked) Pencolor = Color.FromArgb(0, 255, 0);
                if (radioButton3.Checked) Pencolor = Color.FromArgb(0, 0, 255);
                return Pencolor;
            }
            set
            {
                Pencolor = value;
                if (Pencolor == Color.FromArgb(255, 0, 0)) radioButton1.Checked = true;
                if (Pencolor == Color.FromArgb(0, 255, 0)) radioButton2.Checked = true;
                if (Pencolor == Color.FromArgb(0, 0, 255)) radioButton3.Checked = true;
            }
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
  
    }
}
