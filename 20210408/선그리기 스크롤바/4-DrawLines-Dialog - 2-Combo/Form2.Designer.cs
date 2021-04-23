namespace DrawLines
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.hScrollBar3 = new System.Windows.Forms.HScrollBar();
            this.hScrollBar2 = new System.Windows.Forms.HScrollBar();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(207, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "확인";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(307, 372);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "취소";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(398, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(401, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "선굵기";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.hScrollBar3);
            this.groupBox1.Controls.Add(this.hScrollBar2);
            this.groupBox1.Controls.Add(this.hScrollBar1);
            this.groupBox1.Location = new System.Drawing.Point(20, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 317);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Color";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(175, 102);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(43, 21);
            this.textBox3.TabIndex = 5;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(175, 63);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(43, 21);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(175, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(43, 21);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // hScrollBar3
            // 
            this.hScrollBar3.Location = new System.Drawing.Point(24, 102);
            this.hScrollBar3.Maximum = 264;
            this.hScrollBar3.Name = "hScrollBar3";
            this.hScrollBar3.Size = new System.Drawing.Size(134, 27);
            this.hScrollBar3.TabIndex = 2;
            this.hScrollBar3.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar3_Scroll);
            // 
            // hScrollBar2
            // 
            this.hScrollBar2.Location = new System.Drawing.Point(24, 63);
            this.hScrollBar2.Maximum = 264;
            this.hScrollBar2.Name = "hScrollBar2";
            this.hScrollBar2.Size = new System.Drawing.Size(134, 30);
            this.hScrollBar2.TabIndex = 1;
            this.hScrollBar2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar2_Scroll);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(24, 28);
            this.hScrollBar1.Maximum = 264;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(134, 24);
            this.hScrollBar1.TabIndex = 0;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 430);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.HScrollBar hScrollBar2;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.HScrollBar hScrollBar3;
    }
}