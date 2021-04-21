using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ComboBoxTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Text = comboBox1.Text;
        }

        private void comboBox1_TextChanged(object sender, EventArgs e) //콤보박스에 텍스트 에디트 할떄
        {
            Text = comboBox1.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}