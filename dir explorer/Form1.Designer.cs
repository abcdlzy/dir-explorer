namespace dir_explorer
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRead = new System.Windows.Forms.Button();
            this.ofdSource = new System.Windows.Forms.OpenFileDialog();
            this.tbReadFile = new System.Windows.Forms.TextBox();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tvTree = new System.Windows.Forms.TreeView();
            this.gvRs = new System.Windows.Forms.DataGridView();
            this.cbEncoding = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbclip = new System.Windows.Forms.TextBox();
            this.lbClipTips = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvRs)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRead
            // 
            this.btnRead.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRead.Location = new System.Drawing.Point(1028, 6);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 0;
            this.btnRead.Text = "读取";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // tbReadFile
            // 
            this.tbReadFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbReadFile.Location = new System.Drawing.Point(316, 6);
            this.tbReadFile.Name = "tbReadFile";
            this.tbReadFile.Size = new System.Drawing.Size(615, 21);
            this.tbReadFile.TabIndex = 1;
            // 
            // tbPath
            // 
            this.tbPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPath.Location = new System.Drawing.Point(316, 33);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(690, 21);
            this.tbPath.TabIndex = 2;
            // 
            // btnGo
            // 
            this.btnGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGo.Location = new System.Drawing.Point(1028, 33);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 3;
            this.btnGo.Text = "go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "当前路径";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "dir数据路径";
            // 
            // tvTree
            // 
            this.tvTree.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tvTree.Location = new System.Drawing.Point(13, 11);
            this.tvTree.Name = "tvTree";
            this.tvTree.Size = new System.Drawing.Size(208, 505);
            this.tvTree.TabIndex = 6;
            this.tvTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvTree_AfterSelect);
            // 
            // gvRs
            // 
            this.gvRs.AllowUserToAddRows = false;
            this.gvRs.AllowUserToDeleteRows = false;
            this.gvRs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvRs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvRs.Location = new System.Drawing.Point(241, 88);
            this.gvRs.Name = "gvRs";
            this.gvRs.ReadOnly = true;
            this.gvRs.RowTemplate.Height = 23;
            this.gvRs.Size = new System.Drawing.Size(862, 428);
            this.gvRs.TabIndex = 7;
            this.gvRs.DataSourceChanged += new System.EventHandler(this.gvRs_DataSourceChanged);
            this.gvRs.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvRs_CellDoubleClick);
            // 
            // cbEncoding
            // 
            this.cbEncoding.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbEncoding.FormattingEnabled = true;
            this.cbEncoding.Items.AddRange(new object[] {
            "UTF8",
            "Default",
            "Unicode",
            "ASCII",
            "UTF7",
            "UTF32",
            "BigEndianUnicode"});
            this.cbEncoding.Location = new System.Drawing.Point(937, 6);
            this.cbEncoding.Name = "cbEncoding";
            this.cbEncoding.Size = new System.Drawing.Size(71, 20);
            this.cbEncoding.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(268, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "剪贴板";
            // 
            // tbclip
            // 
            this.tbclip.Location = new System.Drawing.Point(316, 61);
            this.tbclip.Name = "tbclip";
            this.tbclip.Size = new System.Drawing.Size(690, 21);
            this.tbclip.TabIndex = 10;
            // 
            // lbClipTips
            // 
            this.lbClipTips.AutoSize = true;
            this.lbClipTips.ForeColor = System.Drawing.Color.Red;
            this.lbClipTips.Location = new System.Drawing.Point(1026, 64);
            this.lbClipTips.Name = "lbClipTips";
            this.lbClipTips.Size = new System.Drawing.Size(0, 12);
            this.lbClipTips.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 528);
            this.Controls.Add(this.lbClipTips);
            this.Controls.Add(this.tbclip);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbEncoding);
            this.Controls.Add(this.gvRs);
            this.Controls.Add(this.tvTree);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.tbReadFile);
            this.Controls.Add(this.btnRead);
            this.Name = "Form1";
            this.Text = "Dir Explorer";
            ((System.ComponentModel.ISupportInitialize)(this.gvRs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.OpenFileDialog ofdSource;
        private System.Windows.Forms.TextBox tbReadFile;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TreeView tvTree;
        private System.Windows.Forms.DataGridView gvRs;
        private System.Windows.Forms.ComboBox cbEncoding;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbclip;
        private System.Windows.Forms.Label lbClipTips;
    }
}

