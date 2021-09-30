
namespace calculator_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.result = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.calculator = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.round13 = new calculator_2.Round();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.round12 = new calculator_2.Round();
            this.round11 = new calculator_2.Round();
            this.round10 = new calculator_2.Round();
            this.round9 = new calculator_2.Round();
            this.round8 = new calculator_2.Round();
            this.round7 = new calculator_2.Round();
            this.round6 = new calculator_2.Round();
            this.round5 = new calculator_2.Round();
            this.round4 = new calculator_2.Round();
            this.round3 = new calculator_2.Round();
            this.round2 = new calculator_2.Round();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.result);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(351, 41);
            this.panel1.TabIndex = 0;
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(80, 12);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(258, 15);
            this.result.TabIndex = 0;
            this.result.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "=";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel2.Controls.Add(this.calculator);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(351, 41);
            this.panel2.TabIndex = 0;
            // 
            // calculator
            // 
            this.calculator.Location = new System.Drawing.Point(81, 13);
            this.calculator.Name = "calculator";
            this.calculator.Size = new System.Drawing.Size(258, 15);
            this.calculator.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Number:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.round13);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.round12);
            this.panel3.Controls.Add(this.round11);
            this.panel3.Controls.Add(this.round10);
            this.panel3.Controls.Add(this.round9);
            this.panel3.Controls.Add(this.round8);
            this.panel3.Controls.Add(this.round7);
            this.panel3.Controls.Add(this.round6);
            this.panel3.Controls.Add(this.round5);
            this.panel3.Controls.Add(this.round4);
            this.panel3.Controls.Add(this.round3);
            this.panel3.Controls.Add(this.round2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(351, 485);
            this.panel3.TabIndex = 0;
            // 
            // round13
            // 
            this.round13.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.round13.FlatAppearance.BorderSize = 0;
            this.round13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.round13.Location = new System.Drawing.Point(13, 79);
            this.round13.Name = "round13";
            this.round13.Size = new System.Drawing.Size(50, 50);
            this.round13.TabIndex = 14;
            this.round13.TabStop = false;
            this.round13.Text = "C";
            this.round13.UseVisualStyleBackColor = false;
            this.round13.Click += new System.EventHandler(this.round1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(15, 199);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(58, 46);
            this.button4.TabIndex = 13;
            this.button4.Text = "+";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(117, 199);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(58, 46);
            this.button3.TabIndex = 13;
            this.button3.Text = "-";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(204, 199);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(58, 46);
            this.button2.TabIndex = 13;
            this.button2.Text = "*";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(282, 199);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(58, 46);
            this.button5.TabIndex = 13;
            this.button5.Text = "/";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button4_Click);
            // 
            // round12
            // 
            this.round12.BackColor = System.Drawing.Color.Violet;
            this.round12.FlatAppearance.BorderSize = 0;
            this.round12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.round12.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.round12.Location = new System.Drawing.Point(291, 135);
            this.round12.Name = "round12";
            this.round12.Size = new System.Drawing.Size(49, 50);
            this.round12.TabIndex = 12;
            this.round12.Text = ".";
            this.round12.UseVisualStyleBackColor = false;
            // 
            // round11
            // 
            this.round11.BackColor = System.Drawing.Color.Violet;
            this.round11.FlatAppearance.BorderSize = 0;
            this.round11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.round11.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.round11.Location = new System.Drawing.Point(238, 135);
            this.round11.Name = "round11";
            this.round11.Size = new System.Drawing.Size(49, 50);
            this.round11.TabIndex = 11;
            this.round11.Text = "9";
            this.round11.UseVisualStyleBackColor = false;
            this.round11.Click += new System.EventHandler(this.round1_Click);
            // 
            // round10
            // 
            this.round10.BackColor = System.Drawing.Color.Violet;
            this.round10.FlatAppearance.BorderSize = 0;
            this.round10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.round10.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.round10.Location = new System.Drawing.Point(182, 135);
            this.round10.Name = "round10";
            this.round10.Size = new System.Drawing.Size(49, 50);
            this.round10.TabIndex = 10;
            this.round10.Text = "8";
            this.round10.UseVisualStyleBackColor = false;
            this.round10.Click += new System.EventHandler(this.round1_Click);
            // 
            // round9
            // 
            this.round9.BackColor = System.Drawing.Color.Violet;
            this.round9.FlatAppearance.BorderSize = 0;
            this.round9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.round9.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.round9.Location = new System.Drawing.Point(126, 135);
            this.round9.Name = "round9";
            this.round9.Size = new System.Drawing.Size(49, 50);
            this.round9.TabIndex = 9;
            this.round9.Text = "7";
            this.round9.UseVisualStyleBackColor = false;
            this.round9.Click += new System.EventHandler(this.round1_Click);
            // 
            // round8
            // 
            this.round8.BackColor = System.Drawing.Color.Violet;
            this.round8.FlatAppearance.BorderSize = 0;
            this.round8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.round8.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.round8.Location = new System.Drawing.Point(70, 135);
            this.round8.Name = "round8";
            this.round8.Size = new System.Drawing.Size(49, 50);
            this.round8.TabIndex = 8;
            this.round8.Text = "6";
            this.round8.UseVisualStyleBackColor = false;
            this.round8.Click += new System.EventHandler(this.round1_Click);
            // 
            // round7
            // 
            this.round7.BackColor = System.Drawing.Color.Violet;
            this.round7.FlatAppearance.BorderSize = 0;
            this.round7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.round7.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.round7.Location = new System.Drawing.Point(14, 135);
            this.round7.Name = "round7";
            this.round7.Size = new System.Drawing.Size(49, 50);
            this.round7.TabIndex = 7;
            this.round7.Text = "5";
            this.round7.UseVisualStyleBackColor = false;
            this.round7.Click += new System.EventHandler(this.round1_Click);
            // 
            // round6
            // 
            this.round6.BackColor = System.Drawing.Color.Violet;
            this.round6.FlatAppearance.BorderSize = 0;
            this.round6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.round6.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.round6.Location = new System.Drawing.Point(291, 79);
            this.round6.Name = "round6";
            this.round6.Size = new System.Drawing.Size(49, 50);
            this.round6.TabIndex = 6;
            this.round6.Text = "4";
            this.round6.UseVisualStyleBackColor = false;
            this.round6.Click += new System.EventHandler(this.round1_Click);
            // 
            // round5
            // 
            this.round5.BackColor = System.Drawing.Color.Violet;
            this.round5.FlatAppearance.BorderSize = 0;
            this.round5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.round5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.round5.Location = new System.Drawing.Point(235, 79);
            this.round5.Name = "round5";
            this.round5.Size = new System.Drawing.Size(49, 50);
            this.round5.TabIndex = 5;
            this.round5.Text = "3";
            this.round5.UseVisualStyleBackColor = false;
            this.round5.Click += new System.EventHandler(this.round1_Click);
            // 
            // round4
            // 
            this.round4.BackColor = System.Drawing.Color.Violet;
            this.round4.FlatAppearance.BorderSize = 0;
            this.round4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.round4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.round4.Location = new System.Drawing.Point(182, 79);
            this.round4.Name = "round4";
            this.round4.Size = new System.Drawing.Size(49, 50);
            this.round4.TabIndex = 4;
            this.round4.Text = "2";
            this.round4.UseVisualStyleBackColor = false;
            this.round4.Click += new System.EventHandler(this.round1_Click);
            // 
            // round3
            // 
            this.round3.BackColor = System.Drawing.Color.Violet;
            this.round3.FlatAppearance.BorderSize = 0;
            this.round3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.round3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.round3.Location = new System.Drawing.Point(126, 79);
            this.round3.Name = "round3";
            this.round3.Size = new System.Drawing.Size(49, 50);
            this.round3.TabIndex = 3;
            this.round3.Text = "1";
            this.round3.UseVisualStyleBackColor = false;
            this.round3.Click += new System.EventHandler(this.round1_Click);
            // 
            // round2
            // 
            this.round2.BackColor = System.Drawing.Color.Violet;
            this.round2.FlatAppearance.BorderSize = 0;
            this.round2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.round2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.round2.Location = new System.Drawing.Point(70, 79);
            this.round2.Name = "round2";
            this.round2.Size = new System.Drawing.Size(49, 50);
            this.round2.TabIndex = 2;
            this.round2.Text = "0";
            this.round2.UseVisualStyleBackColor = false;
            this.round2.Click += new System.EventHandler(this.round1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Aquamarine;
            this.button1.Location = new System.Drawing.Point(14, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(326, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "=";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 526);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label calculator;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private Round round12;
        private Round round11;
        private Round round10;
        private Round round9;
        private Round round8;
        private Round round7;
        private Round round6;
        private Round round5;
        private Round round4;
        private Round round3;
        private Round round2;
        private Round round13;
    }
}

