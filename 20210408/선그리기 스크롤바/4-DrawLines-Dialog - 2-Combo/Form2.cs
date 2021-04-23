using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawLines
{
    public partial class Form2 : Form
    {
        private Color DialogPenColor;
        public int iDialogPenWidth { get; set; }
        private Color setColor;
        int red;
        int green;
        int blue;
        public Color Color
        {
            get
            {

                DialogPenColor = Color.FromArgb(red, green, blue);
                return DialogPenColor;
            }
            set
            {
                setColor = value;
                red = setColor.R;
                green = setColor.G;
                blue = setColor.B;
            }
        }
        public Form2()
        {
            InitializeComponent();
        }

        /*private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            iDialogPenWidth = (((ComboBox)sender).SelectedIndex + 1) * 2;
            
        }*/

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text = red.ToString();
            textBox2.Text = green.ToString();
            textBox3.Text = blue.ToString();
            hScrollBar1.Value = red;
            hScrollBar2.Value = blue;
            hScrollBar3.Value = green;
            label5.Invalidate();
        }

        /*private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                iDialogPenWidth = int.Parse(comboBox1.Text);
            }
            catch
            {

            }
        }*/

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            red = hScrollBar1.Value;
            textBox1.Text = red.ToString();
            label5.Invalidate();
        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            green = hScrollBar2.Value;
            textBox2.Text = green.ToString();
            label5.Invalidate();
        }

        private void hScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            blue = hScrollBar3.Value;
            textBox3.Text = blue.ToString();
            label5.Invalidate();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            try
            {
                red = int.Parse(textBox1.Text);
                hScrollBar1.Value = red;
            }
            catch
            {
                textBox1.Text = red.ToString();
            }
            label5.Invalidate();
        }
        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                iDialogPenWidth = int.Parse(comboBox1.Text);
            }
            catch
            {

            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            iDialogPenWidth = (((ComboBox)sender).SelectedIndex + 1) * 2;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                green = int.Parse(textBox2.Text);
                hScrollBar2.Value = green;
            }
            catch
            {
                textBox2.Text = green.ToString();
            }
            label5.Invalidate();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                green = int.Parse(textBox2.Text);
                hScrollBar3.Value = blue;
            }
            catch
            {
                textBox3.Text = blue.ToString();
            }
            label5.Invalidate();
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Paint(object sender, PaintEventArgs e)
        {
            //Graphics G = CreateGraphics();
            //G.DrawLine(new Pen(DialogPenColor, iDialogPenWidth), 0, 0, label5.Width, label5.Height);
            e.Graphics.DrawLine(new Pen(DialogPenColor, iDialogPenWidth), 0, 0, label5.Width, label5.Height);
        }
    }
}
