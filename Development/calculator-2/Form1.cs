using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator_2
{
    public partial class Form1 : Form
    {
        double n1, n2, n3;
        string pro;

        private void button4_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            n1 = Convert.ToDouble(result.Text);
            pro = btn.Text;
           
              if (calculator.Text != "")
              {
                   calculator.Text = calculator.Text + pro;
              }
              else
              {
                calculator.Text = result.Text + pro;
              }
             

            //calculator.Text = calculator.Text + pro;
            result.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            n2 = Convert.ToDouble(result.Text);

            if (pro == "+")
            {
                n3 = n1 + n2;
                result.Text =Convert.ToString(n3);
            }
            else if (pro == "-")
            {
                n3 = n1 - n2;
                result.Text = Convert.ToString(n3);
            }
            else if (pro == "*")
            {
                n3 = n1 * n2;
                result.Text = Convert.ToString(n3);
            }
            else if (pro == "/")
            {
                n3 = n1 / n2;
                result.Text = Convert.ToString(n3);
            }
            else
            {
                calculator.Text = "";
            }
            //calculator.Text = "";
        
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void round1_Click(object sender, EventArgs e)
        {
            // btn for send
            Button btn = (Button)sender;

            // check the btn and send info to the label


            if (result.Text == "0")
            {
                result.Text = "";
                result.Text = result.Text + btn.Text;
                result.Text = calculator.Text;
            }
            else
            {
                result.Text = result.Text + btn.Text;
                calculator.Text = result.Text;
            }





        }
    }
}
