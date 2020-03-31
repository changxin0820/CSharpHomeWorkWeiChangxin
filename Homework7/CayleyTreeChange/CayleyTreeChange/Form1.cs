using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CayleyTreeChange
{
    public partial class Form1 : Form
    {

        double th1 = 30 * Math.PI / 180;
        double th2 = 20 * Math.PI / 180;
        double per1 = 0.6;
        double per2 = 0.7;
        int n = 10;
        double leng = 100;
        Pen pen = Pens.Red;
        public Form1()
        {
            InitializeComponent();
        }

       private Graphics graphics;

    
void drawCayleyTree(int n,double x0, double y0, double leng, double th)
 {

    if (n ==0)return;

    

    double x1 = x0 + leng * Math.Cos(th);
     
    double y1 = y0 + leng * Math.Sin(th);

    drawLine(x0 , y0, x1, y1);


    drawCayleyTree(n-1, x1 , y1 , per1* leng, th + th1);

    drawCayleyTree(n-1, x1 , y1, per2* leng, th-th2);
 }
        private void button2_Click(object sender, EventArgs e)//清除键
        {
            graphics.Clear(this.panel1.BackColor);
            
        }
        void drawLine(double x0, double y0, double x1, double y1)
        {
            graphics.DrawLine(pen, (int)x0, (int)y0, (int)x1, (int)y1);
        }

        public  void button1_Click_1(object sender, EventArgs e)//绘画树
        {
            if (graphics == null) graphics = this.panel1.CreateGraphics();
            
            drawCayleyTree(n, 200, 310, leng, -Math.PI / 2);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            try
            {
                n = int.Parse(textBox1.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("请输入正确的数值！");
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                leng = double.Parse(textBox1.Text);
            }
            catch(Exception)
            {
                MessageBox.Show("请输入正确的数值！");
            }
           
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                per1 = double.Parse(textBox1.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("请输入正确的数值！");
            }

           
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                per2 = double.Parse(textBox1.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("请输入正确的数值！");
            }
            
        }

      

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
                if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (Char)8)
                {
                    e.Handled = true;
                }
        
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
           
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            leng = Convert.ToInt32(trackBar1.Value);
        }
        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            per1 = Convert.ToDouble(trackBar2.Value)*0.01;
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            per2 = Convert.ToDouble(trackBar3.Value)*0.01;
        }
      

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            th1= Convert.ToDouble(trackBar4.Value)*Math.PI/180 ;
        }

        private void trackBar5_Scroll(object sender, EventArgs e)
        {
            th2 = Convert.ToDouble(trackBar5.Value) * Math.PI / 180;
        }


        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            label5.Text = Convert.ToString(trackBar1.Value);
        }
        private void trackBar2_ValueChanged(object sender, EventArgs e)
        {
            label6.Text = Convert.ToString(trackBar2.Value) + "%";
        }



        private void trackBar3_ValueChanged(object sender, EventArgs e)
        {
            label7.Text = Convert.ToString(trackBar3.Value) + "%";
        }

        private void trackBar4_ValueChanged(object sender, EventArgs e)
        {
            label10.Text = Convert.ToString(trackBar4.Value)+"度";
        }

        private void trackBar5_ValueChanged(object sender, EventArgs e)
        {
            label11.Text = Convert.ToString(trackBar5.Value)+"度";
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pen = Pens.Blue;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pen = Pens.Black;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            pen = Pens.Red;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            pen = Pens.Green;
        }
    }
}
