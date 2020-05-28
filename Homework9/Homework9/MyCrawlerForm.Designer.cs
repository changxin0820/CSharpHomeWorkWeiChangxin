namespace Homework9
{
    partial class MyCrawlerForm
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
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelStart = new System.Windows.Forms.Label();
            this.序号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.网址 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.爬取状态 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(72, 33);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(346, 25);
            this.txtUrl.TabIndex = 0;
            this.txtUrl.Text = "https://www.baidu.com";
            this.txtUrl.TextChanged += new System.EventHandler(this.txtUrl_TextChanged_1);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(455, 34);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "开始爬取";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // statusStrip2
            // 
            this.statusStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip2.Location = new System.Drawing.Point(0, 474);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(1040, 22);
            this.statusStrip2.TabIndex = 4;
            this.statusStrip2.Text = "statusStrip2";
            this.statusStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip2_ItemClicked);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.序号,
            this.网址,
            this.爬取状态});
            this.dataGridView1.Location = new System.Drawing.Point(72, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(956, 375);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // labelStart
            // 
            this.labelStart.AutoSize = true;
            this.labelStart.Location = new System.Drawing.Point(800, 92);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(67, 15);
            this.labelStart.TabIndex = 4;
            this.labelStart.Text = "开始爬取";
            // 
            // 序号
            // 
            this.序号.DataPropertyName = "index";
            this.序号.HeaderText = "爬取序号";
            this.序号.Name = "序号";
            this.序号.Width = 96;
            // 
            // 网址
            // 
            this.网址.DataPropertyName = "URL";
            this.网址.HeaderText = "爬取网址";
            this.网址.Name = "网址";
            this.网址.Width = 500;
            // 
            // 爬取状态
            // 
            this.爬取状态.DataPropertyName = "Status";
            this.爬取状态.HeaderText = "状态";
            this.爬取状态.Name = "爬取状态";
            this.爬取状态.Width = 80;
            // 
            // MyCrawlerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 496);
            this.Controls.Add(this.labelStart);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.statusStrip2);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtUrl);
            this.Name = "MyCrawlerForm";
            this.Text = "MyCrawlerForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn 序号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 网址;
        private System.Windows.Forms.DataGridViewTextBoxColumn 爬取状态;
    }
}