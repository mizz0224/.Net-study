﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AboutDialog
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Form2 dlg = new Form2();
			dlg.ShowDialog();//form2를 다이얼로그 형태로 호출
			dlg.Dispose();
		}

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
