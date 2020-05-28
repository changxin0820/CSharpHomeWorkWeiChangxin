using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework9
{
    public partial class Form1 : Form
    {
        Crawler crawler = new Crawler();
        public Form1()
        {
            InitializeComponent();
            crawler.PageDownloaded += Crawler_PageDownloaded;
        }

        private void Crawler_PageDownloaded(string obj)
        {
            if (this.listBox1.InvokeRequired)
            {
                Action<String> action = this.AddUrl;
                this.Invoke(action, new object[] { obj });
            }
            else
            {
                listBox1.Items.Add(obj);
            }
        }

        private void AddUrl(string url)
        {
            listBox1.Items.Add(url);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            crawler.StartURL = txtUrl.Text;
            listBox1.Items.Clear();
            new Thread(crawler.Start).Start();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
