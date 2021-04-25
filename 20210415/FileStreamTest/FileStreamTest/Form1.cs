﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FileStreamTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] data = { 65, 66, 67, 68, 69, 70, 71, 72 };

            saveFileDialog1.InitialDirectory = "C:\\desktop";
            //saveFileDialog1.InitialDirectory = Environment.CurrentDirectory; //<- 현재디렉토리 : 환경변수
            saveFileDialog1.Title = "파일을 잽싸게 고르셔";
            saveFileDialog1.Filter = "텍스트 파일|*.txt|모든 파일|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.Create,
                FileAccess.Write);
                fs.Write(data, 0, data.Length);
                fs.Close();
                MessageBox.Show(@"C:의 fs.txt 파일에 기록했습니다.");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            byte[] data = new byte[8];
            openFileDialog1.InitialDirectory = "C:\\desktop";
            //openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog1.Title = "파일을 잽싸게 고르셔";
            openFileDialog1.Filter = "텍스트 파일|*.txt|모든 파일|*.*";
            openFileDialog1.ShowReadOnly = true;
            openFileDialog1.Multiselect = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.OpenOrCreate,
                        FileAccess.Read);
                    fs.Read(data, 0, data.Length);
                    fs.Close();

                    string result = "";
                    for (int i = 0; i < data.Length; i++)
                    {
                        result += data[i].ToString() + ",";
                    }
                    MessageBox.Show(result, "파일 내용");
                }
                catch (FileNotFoundException)
                {
                    MessageBox.Show("지정한 파일이 없습니다.");
                }
            }
        }
    }
}