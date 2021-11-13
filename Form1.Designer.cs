namespace lab_2
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.answer2 = new System.Windows.Forms.Button();
            this.answer1 = new System.Windows.Forms.Button();
            this.ten = new System.Windows.Forms.RadioButton();
            this.twenty = new System.Windows.Forms.RadioButton();
            this.fifty = new System.Windows.Forms.RadioButton();
            this.input1 = new System.Windows.Forms.TextBox();
            this.input2 = new System.Windows.Forms.TextBox();
            this.input3 = new System.Windows.Forms.TextBox();
            this.output1 = new System.Windows.Forms.TextBox();
            this.output2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label1.Location = new System.Drawing.Point(49, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "(";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label2.Location = new System.Drawing.Point(184, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "+";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label3.Location = new System.Drawing.Point(326, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = ")   /";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.Location = new System.Drawing.Point(149, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Result";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(217, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Persent of taken  result";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label8.Location = new System.Drawing.Point(149, 370);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Result";
            // 
            // answer2
            // 
            this.answer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.answer2.ForeColor = System.Drawing.Color.DarkRed;
            this.answer2.Location = new System.Drawing.Point(235, 320);
            this.answer2.Name = "answer2";
            this.answer2.Size = new System.Drawing.Size(80, 30);
            this.answer2.TabIndex = 8;
            this.answer2.Text = "Answer";
            this.answer2.UseVisualStyleBackColor = true;
            this.answer2.Click += new System.EventHandler(this.answer2_Click);
            // 
            // answer1
            // 
            this.answer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.answer1.ForeColor = System.Drawing.Color.DarkRed;
            this.answer1.Location = new System.Drawing.Point(235, 115);
            this.answer1.Name = "answer1";
            this.answer1.Size = new System.Drawing.Size(80, 30);
            this.answer1.TabIndex = 9;
            this.answer1.Text = "Answer";
            this.answer1.UseVisualStyleBackColor = true;
            this.answer1.Click += new System.EventHandler(this.answer1_Click);
            // 
            // ten
            // 
            this.ten.AutoSize = true;
            this.ten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.ten.Location = new System.Drawing.Point(235, 233);
            this.ten.Name = "ten";
            this.ten.Size = new System.Drawing.Size(54, 21);
            this.ten.TabIndex = 10;
            this.ten.TabStop = true;
            this.ten.Text = "10%";
            this.ten.UseVisualStyleBackColor = true;
            // 
            // twenty
            // 
            this.twenty.AutoSize = true;
            this.twenty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.twenty.Location = new System.Drawing.Point(235, 256);
            this.twenty.Name = "twenty";
            this.twenty.Size = new System.Drawing.Size(54, 21);
            this.twenty.TabIndex = 11;
            this.twenty.TabStop = true;
            this.twenty.Text = "20%";
            this.twenty.UseVisualStyleBackColor = true;
            // 
            // fifty
            // 
            this.fifty.AutoSize = true;
            this.fifty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.fifty.Location = new System.Drawing.Point(235, 279);
            this.fifty.Name = "fifty";
            this.fifty.Size = new System.Drawing.Size(54, 21);
            this.fifty.TabIndex = 12;
            this.fifty.TabStop = true;
            this.fifty.Text = "50%";
            this.fifty.UseVisualStyleBackColor = true;
            // 
            // input1
            // 
            this.input1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.input1.Location = new System.Drawing.Point(78, 54);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(100, 26);
            this.input1.TabIndex = 13;
            this.input1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // input2
            // 
            this.input2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.input2.Location = new System.Drawing.Point(220, 54);
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(100, 26);
            this.input2.TabIndex = 14;
            // 
            // input3
            // 
            this.input3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.input3.Location = new System.Drawing.Point(384, 54);
            this.input3.Name = "input3";
            this.input3.Size = new System.Drawing.Size(100, 26);
            this.input3.TabIndex = 15;
            // 
            // output1
            // 
            this.output1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.output1.Location = new System.Drawing.Point(220, 155);
            this.output1.Name = "output1";
            this.output1.Size = new System.Drawing.Size(100, 26);
            this.output1.TabIndex = 16;
            // 
            // output2
            // 
            this.output2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.output2.Location = new System.Drawing.Point(220, 365);
            this.output2.Name = "output2";
            this.output2.Size = new System.Drawing.Size(100, 26);
            this.output2.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 450);
            this.Controls.Add(this.output2);
            this.Controls.Add(this.output1);
            this.Controls.Add(this.input3);
            this.Controls.Add(this.input2);
            this.Controls.Add(this.input1);
            this.Controls.Add(this.fifty);
            this.Controls.Add(this.twenty);
            this.Controls.Add(this.ten);
            this.Controls.Add(this.answer1);
            this.Controls.Add(this.answer2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Claculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button answer2;
        private System.Windows.Forms.Button answer1;
        private System.Windows.Forms.RadioButton ten;
        private System.Windows.Forms.RadioButton twenty;
        private System.Windows.Forms.RadioButton fifty;
        private System.Windows.Forms.TextBox input1;
        private System.Windows.Forms.TextBox input2;
        private System.Windows.Forms.TextBox input3;
        private System.Windows.Forms.TextBox output1;
        private System.Windows.Forms.TextBox output2;
    }
}

