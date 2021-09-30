
namespace calculator
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.round1 = new calculator.Round();
            this.round2 = new calculator.Round();
            this.round3 = new calculator.Round();
            this.round4 = new calculator.Round();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 41);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(12, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(279, 88);
            this.panel2.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepPink;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(12, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "=";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // round1
            // 
            this.round1.BackColor = System.Drawing.Color.DeepPink;
            this.round1.ForeColor = System.Drawing.Color.Yellow;
            this.round1.Location = new System.Drawing.Point(12, 169);
            this.round1.Name = "round1";
            this.round1.Size = new System.Drawing.Size(58, 50);
            this.round1.TabIndex = 3;
            this.round1.Text = "+";
            this.round1.UseVisualStyleBackColor = false;
            // 
            // round2
            // 
            this.round2.Location = new System.Drawing.Point(159, 222);
            this.round2.Name = "round2";
            this.round2.Size = new System.Drawing.Size(94, 29);
            this.round2.TabIndex = 4;
            this.round2.Text = "round2";
            this.round2.UseVisualStyleBackColor = true;
            // 
            // round3
            // 
            this.round3.Location = new System.Drawing.Point(185, 314);
            this.round3.Name = "round3";
            this.round3.Size = new System.Drawing.Size(77, 60);
            this.round3.TabIndex = 5;
            this.round3.Text = "round3";
            this.round3.UseVisualStyleBackColor = true;
            // 
            // round4
            // 
            this.round4.Location = new System.Drawing.Point(107, 165);
            this.round4.Name = "round4";
            this.round4.Size = new System.Drawing.Size(64, 59);
            this.round4.TabIndex = 6;
            this.round4.Text = "round4";
            this.round4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(305, 455);
            this.Controls.Add(this.round4);
            this.Controls.Add(this.round3);
            this.Controls.Add(this.round2);
            this.Controls.Add(this.round1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Opacity = 0.75D;
            this.Text = "Calculator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private Round round1;
        private Round round2;
        private Round round3;
        private Round round4;
    }
}

