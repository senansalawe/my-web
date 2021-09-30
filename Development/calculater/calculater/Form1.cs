using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculater
{
    public partial class Form1 : Form
    {
        int num1;
        int num2;
        int total;
        public Form1()
        {
            InitializeComponent();
        }
       
        //Sum
        private void button1_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(textBox1.Text);
            num2 = Convert.ToInt32(textBox2.Text);
            total = num1 + num2;
            textBox3.Text = Convert.ToString(total);
        }
        //min
        private void button2_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(textBox1.Text);
            num2 = Convert.ToInt32(textBox2.Text);
            total = num1 - num2;
            textBox3.Text = Convert.ToString(total);
        }
        //Mult
        private void button3_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(textBox1.Text);
            num2 = Convert.ToInt32(textBox2.Text);
            total = num1 * num2;
            textBox3.Text = Convert.ToString(total);
        }
        // Div
        private void button4_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(textBox1.Text);
            num2 = Convert.ToInt32(textBox2.Text);
            total = num1 / num2;
            textBox3.Text = Convert.ToString(total);
        }
    }
}
