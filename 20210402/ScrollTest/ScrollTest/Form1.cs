using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ScrollTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)  //여기도 앞에처럼 핸들러 통합을 이용함
        {
            button1.BackColor = Color.FromArgb(hScrollBar1.Value, //범위는 maximum,minimum으로 조정함!!
                hScrollBar2.Value, hScrollBar3.Value);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}