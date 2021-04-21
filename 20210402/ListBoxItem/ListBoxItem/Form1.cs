using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ListBoxItem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 항목 추가
        private void button1_Click(object sender, EventArgs e)
        {
            string Item = textBox1.Text;
            listBox1.Items.Add(Item);
            textBox1.Text = "";
        }

        // 항목 제거
        private void button2_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (index != -1) //index 가 -1의 의미 : 아무것도 선택되지 않았을때는 동작하지 않게
            {
                listBox1.Items.RemoveAt(index);
            }
        }

        // 모두 제거
        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}