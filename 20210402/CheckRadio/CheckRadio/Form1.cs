using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CheckRadio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            button1.BackColor = Color.Green;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            button1.BackColor = Color.Blue;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.TextAlign = ContentAlignment.TopLeft;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            button1.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.TextAlign = ContentAlignment.BottomRight;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) //체크박스를 클릭했을때 이 이벤트가 발생하는데 이이벤트(e)와 더불어 최상위클래스(object)인 sender에 담아서 보낸다
        {
            if (((CheckBox)sender).Checked) //downcasting : 최상위 객체인 sender에 checkbox를 담았기 때문
                                            //checkbox -> sender(object)에 담는것을 업 캐스팅 반대는 다운캐스팅이라고 하는데, 업캐스팅은 안전하지만 다운캐스팅은 불안전할수도 있다
                                            //근데 여기서는 안전하다 왜? -> 어차피 체크박스를 sender(object)에 담았다가 다시 내리는(다운캐스팅)것이기 때문
            {
                button1.Enabled = false;//disable
            }
            else
            {
                button1.Enabled = true;//enable
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                button1.Visible = false;
            }
            else
            {
                button1.Visible = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}