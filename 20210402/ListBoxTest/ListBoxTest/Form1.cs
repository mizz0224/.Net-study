using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ListBoxTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBox1.SetSelected(0, true);//<- 최초의 선택된 리스트(리스트 자동 선택)
             
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Text = listBox1.Text; // == this.Text = listBox1.Text;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}