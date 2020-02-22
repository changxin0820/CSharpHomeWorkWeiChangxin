using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     

    

        private void button1_Click_1(object sender, EventArgs e)
        {
            label2.Text = "+";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "-";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            label2.Text = "*";
        }
        private void button4_Click_1(object sender, EventArgs e)
        {
            label2.Text = "/";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string txt1 = textBox1.Text;
            double x1 = 0;
            if (!double.TryParse(txt1, out x1)) //如果 txt1 不能转换成 int 类型
            {
                MessageBox.Show("第一个文本框不是有效数");
                return;
            }
            else
            {
                x1 = double.Parse(txt1);
            }
            string txt2 = textBox2.Text;
            double x2 = 0;
            if (!double.TryParse(txt2, out x2)) //如果 txt1 不能转换成 int 类型
            {
                MessageBox.Show("第二个文本框不是有效整数");
                return;
            }
            else
            {
                x2 = double.Parse(txt2);
            }
            double result = 0;
            switch (label2.Text) {
                case "+":
                    result = x1 + x2;
                    break;
                case "-":
                    result = x1 - x2;
                    break;
                case "*":
                    result = x1 * x2;
                    break;
                case "/":
                    // Ask the user to enter a non-zero divisor.
                    if (x2 == 0)
                    {
                        MessageBox.Show("0不能作为被除数！");

                    }
                    else
                    {
                        result = x1 / x2;
                    }
                    break;
                // Return text for an incorrect option entry.
                default:
                    break;

                   


            }
            
                   label3.Text = result.ToString();


        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
