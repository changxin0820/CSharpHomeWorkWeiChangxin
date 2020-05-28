using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework9
{
    public partial class MyCrawlerForm: Form
    {
        BindingSource resultBindingSource = new BindingSource();
        MyCrawler crawler = new MyCrawler();

        public MyCrawlerForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = resultBindingSource;
            crawler.PageDownloaded += Crawler_PageDownloaded;
            crawler.CrawlerStopped += Crawler_CrawlerStopped;
        }

        private void Crawler_CrawlerStopped(MyCrawler obj)
        {
            Action action = () => labelStart.Text = "爬虫已停止";
            if (this.InvokeRequired)
            {
                this.Invoke(action);
            }
            else
            {
                action();
            }
        }

        private void Crawler_PageDownloaded(MyCrawler crawler, string url, string info)
        {
            var pageInfo = new { Index = resultBindingSource.Count + 1, URL = url, Status = info };
            Action action = () => { resultBindingSource.Add(pageInfo); };
            if (this.InvokeRequired)
            {
                this.Invoke(action);
            }
            else
            {
                action();
            }
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            resultBindingSource.Clear();
            crawler.StartURL = txtUrl.Text;

            Match match = Regex.Match(crawler.StartURL, MyCrawler.urlParseRegex);
            if (match.Length == 0) return;
            string host = match.Groups["host"].Value;
            crawler.HostFilter = "^" + host + "$";
            crawler.FileFilter = ".html?$";

            Task task = Task.Run(() => crawler.Start());
            labelStart.Text = "爬虫已启动....开始爬取";


        }

        private void txtUrl_TextChanged(object sender, EventArgs e)
        {

        }

     

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtUrl_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void statusStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
