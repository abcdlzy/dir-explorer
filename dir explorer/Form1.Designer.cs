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
            this.components = new System.ComponentModel.Container();
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbSearchTips = new System.Windows.Forms.Label();
            this.tbSearchClip = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbcase = new System.Windows.Forms.CheckBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.tbsearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gvSearch = new System.Windows.Forms.DataGridView();
            this.toolTipSearch = new System.Windows.Forms.ToolTip(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.gvRs)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRead
            // 
            this.btnRead.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRead.Location = new System.Drawing.Point(804, 11);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(61, 23);
            this.btnRead.TabIndex = 0;
            this.btnRead.Text = "读取";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // tbReadFile
            // 
            this.tbReadFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbReadFile.Location = new System.Drawing.Point(86, 13);
            this.tbReadFile.Name = "tbReadFile";
            this.tbReadFile.Size = new System.Drawing.Size(641, 21);
            this.tbReadFile.TabIndex = 1;
            // 
            // tbPath
            // 
            this.tbPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPath.Location = new System.Drawing.Point(86, 40);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(712, 21);
            this.tbPath.TabIndex = 2;
            // 
            // btnGo
            // 
            this.btnGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGo.Location = new System.Drawing.Point(804, 40);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(61, 23);
            this.btnGo.TabIndex = 3;
            this.btnGo.Text = "go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "当前路径";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "dir数据路径";
            // 
            // tvTree
            // 
            this.tvTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvTree.Location = new System.Drawing.Point(3, 6);
            this.tvTree.Name = "tvTree";
            this.tvTree.Size = new System.Drawing.Size(239, 517);
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
            this.gvRs.Location = new System.Drawing.Point(3, 95);
            this.gvRs.Name = "gvRs";
            this.gvRs.ReadOnly = true;
            this.gvRs.RowTemplate.Height = 23;
            this.gvRs.Size = new System.Drawing.Size(864, 428);
            this.gvRs.TabIndex = 7;
            this.gvRs.DataSourceChanged += new System.EventHandler(this.gvRs_DataSourceChanged);
            this.gvRs.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvRs_CellDoubleClick);
            // 
            // cbEncoding
            // 
            this.cbEncoding.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbEncoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEncoding.FormattingEnabled = true;
            this.cbEncoding.Items.AddRange(new object[] {
            "UTF8",
            "Default",
            "Unicode",
            "ASCII",
            "UTF7",
            "UTF32",
            "BigEndianUnicode"});
            this.cbEncoding.Location = new System.Drawing.Point(733, 13);
            this.cbEncoding.Name = "cbEncoding";
            this.cbEncoding.Size = new System.Drawing.Size(65, 20);
            this.cbEncoding.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "剪贴板";
            // 
            // tbclip
            // 
            this.tbclip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbclip.Location = new System.Drawing.Point(86, 68);
            this.tbclip.Name = "tbclip";
            this.tbclip.Size = new System.Drawing.Size(710, 21);
            this.tbclip.TabIndex = 10;
            // 
            // lbClipTips
            // 
            this.lbClipTips.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbClipTips.AutoSize = true;
            this.lbClipTips.ForeColor = System.Drawing.Color.Red;
            this.lbClipTips.Location = new System.Drawing.Point(802, 77);
            this.lbClipTips.Name = "lbClipTips";
            this.lbClipTips.Size = new System.Drawing.Size(0, 12);
            this.lbClipTips.TabIndex = 11;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1130, 555);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1122, 529);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "浏览";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lbSearchTips);
            this.tabPage2.Controls.Add(this.tbSearchClip);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.cbcase);
            this.tabPage2.Controls.Add(this.btnsearch);
            this.tabPage2.Controls.Add(this.tbsearch);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.gvSearch);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1122, 529);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "搜索";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbSearchTips
            // 
            this.lbSearchTips.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSearchTips.AutoSize = true;
            this.lbSearchTips.ForeColor = System.Drawing.Color.Red;
            this.lbSearchTips.Location = new System.Drawing.Point(920, 41);
            this.lbSearchTips.Name = "lbSearchTips";
            this.lbSearchTips.Size = new System.Drawing.Size(0, 12);
            this.lbSearchTips.TabIndex = 7;
            // 
            // tbSearchClip
            // 
            this.tbSearchClip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearchClip.Location = new System.Drawing.Point(77, 38);
            this.tbSearchClip.Name = "tbSearchClip";
            this.tbSearchClip.Size = new System.Drawing.Size(837, 21);
            this.tbSearchClip.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "当前选择";
            // 
            // cbcase
            // 
            this.cbcase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbcase.AutoSize = true;
            this.cbcase.Checked = true;
            this.cbcase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbcase.Location = new System.Drawing.Point(936, 13);
            this.cbcase.Name = "cbcase";
            this.cbcase.Size = new System.Drawing.Size(84, 16);
            this.cbcase.TabIndex = 4;
            this.cbcase.Text = "忽略大小写";
            this.cbcase.UseVisualStyleBackColor = true;
            // 
            // btnsearch
            // 
            this.btnsearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsearch.Location = new System.Drawing.Point(1026, 9);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 23);
            this.btnsearch.TabIndex = 3;
            this.btnsearch.Text = "搜索";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // tbsearch
            // 
            this.tbsearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbsearch.Location = new System.Drawing.Point(77, 11);
            this.tbsearch.Name = "tbsearch";
            this.tbsearch.Size = new System.Drawing.Size(837, 21);
            this.tbsearch.TabIndex = 2;
            this.tbsearch.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tbsearch_MouseMove);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "搜索关键词";
            // 
            // gvSearch
            // 
            this.gvSearch.AllowUserToAddRows = false;
            this.gvSearch.AllowUserToDeleteRows = false;
            this.gvSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSearch.Location = new System.Drawing.Point(7, 63);
            this.gvSearch.Name = "gvSearch";
            this.gvSearch.ReadOnly = true;
            this.gvSearch.RowTemplate.Height = 23;
            this.gvSearch.Size = new System.Drawing.Size(1109, 460);
            this.gvSearch.TabIndex = 0;
            this.gvSearch.DataSourceChanged += new System.EventHandler(this.gvSearch_DataSourceChanged);
            this.gvSearch.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvSearch_CellDoubleClick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tvTree);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gvRs);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.lbClipTips);
            this.splitContainer1.Panel2.Controls.Add(this.btnGo);
            this.splitContainer1.Panel2.Controls.Add(this.tbReadFile);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.tbclip);
            this.splitContainer1.Panel2.Controls.Add(this.tbPath);
            this.splitContainer1.Panel2.Controls.Add(this.cbEncoding);
            this.splitContainer1.Panel2.Controls.Add(this.btnRead);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Size = new System.Drawing.Size(1122, 529);
            this.splitContainer1.SplitterDistance = 245;
            this.splitContainer1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 579);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Dir Explorer";
            ((System.ComponentModel.ISupportInitialize)(this.gvRs)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSearch)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.TextBox tbsearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView gvSearch;
        private System.Windows.Forms.CheckBox cbcase;
        private System.Windows.Forms.Label lbSearchTips;
        private System.Windows.Forms.TextBox tbSearchClip;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolTip toolTipSearch;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}

