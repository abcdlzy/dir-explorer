using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace dir_explorer
{
    public partial class Form1 : Form
    {
        string nowFileText = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            DialogResult result = ofdSource.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = ofdSource.FileName;
                tbReadFile.Text = file;
                try
                {
                    nowFileText = File.ReadAllText(file,Encoding.Default);
                    format();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void format()
        {
            string[] line = nowFileText.Replace("\r\n","\n").Split('\n');

            //开始判断 检测* 的目录或者类似于 Directory of *

            //读取当前目录的东西

            //检测结束


            ;
        }

        
    }
}
