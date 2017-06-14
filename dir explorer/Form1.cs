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
        List<FolderResult> lfr = new List<FolderResult>();
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
                    bindTree();
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

            

            status st = status.checking;
            FolderResult nowFR = new FolderResult();
            for(int i = 0; i < line.Length; i++)
            {
                //开始判断 检测* 的目录或者类似于 Directory of *
                if (st == status.checking)
                {
                    if (line[i] == "")
                    {
                        st = status.checkingPath;
                    }
                }
                //获取当前目录路径
                else if (st == status.checkingPath)
                {
                    if (line[i] != "")
                    {
                        string nowLineObj = line[i].Trim();

                        //处理多国语言
                        //936          中国 - 简体中文(GB2312)
                        nowLineObj = nowLineObj.Replace("的目录", "").Trim();
                        //65001        Unicode(UTF - 8)
                        nowLineObj = nowLineObj.Replace("Directory of", "").Trim();

                        nowFR.path = nowLineObj;
                    }
                    else
                    {
                        st = status.checkingItem;
                    }
                }

                //读取当前目录的东西
                else if (st == status.checkingItem)
                {
                    item it = new item(line[i]);
                    if (it.IsVaild)
                    {
                        nowFR.listObj.Add(it);
                    }
                    else
                    {
                        st = status.end;
                    }
                }

                //检测结束
                if (st == status.end)
                {
                    lfr.Add(nowFR);
                    nowFR = new FolderResult();
                    st = status.checking;
                }
            }




            ;
        }

        
        public enum status
        {
            checking,
            checkingPath,
            checkingItem,
            end

        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            bindData(tbPath.Text);
        }

        private void bindData(string path)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("时间", typeof(String));
            dt.Columns.Add("信息", typeof(String));
            dt.Columns.Add("名称", typeof(String));
            

            foreach (var fr in lfr)
            {
                if (fr.path == path)
                {
                    foreach(var item in fr.listObj)
                    {
                        DataRow dr = dt.NewRow();
                        dr["时间"] = item.getTime();
                        dr["信息"] = item.getInfo();
                        dr["名称"] = item.getName();
                        
                        dt.Rows.Add(dr);

                    }
                    break;
                }
            }

            gvRs.DataSource = dt;
            
        }

        private void gvRs_DataSourceChanged(object sender, EventArgs e)
        {
            gvRs.Columns[0].Width = 150;
            gvRs.Columns[1].Width = 150;
            gvRs.Columns[2].Width = 500;

            gvRs.Sort(gvRs.Columns[1],ListSortDirection.Ascending);
        }

        private void gvRs_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gvRs.Rows[e.RowIndex].Cells[1].Value.ToString() == "<DIR>")
            {
                if (gvRs.Rows[e.RowIndex].Cells[2].Value.ToString() == ".")
                {
                    tbPath.Text = getParentPath(getParentPath(tbPath.Text));
                }
                else if (gvRs.Rows[e.RowIndex].Cells[2].Value.ToString() == "..")
                {
                    tbPath.Text = getParentPath(tbPath.Text);
                }
                else
                {
                    tbPath.Text += "\\"+ gvRs.Rows[e.RowIndex].Cells[2].Value.ToString();
                    
                }
                tbPath.Text = tbPath.Text.Replace("\\\\", "\\");
                bindData(tbPath.Text);

                


            }
        }

        private void bindTree()
        {
            if (lfr.Count > 0)
            {
                tvTree.Nodes.Add(buildTree(lfr[0].path, lfr[0].path));
            }
        }

        private TreeNode buildTree(string path,string showName)
        {
            var childDir = getChildDir(path);
            if (childDir.Count > 0)
            {
                TreeNode tn = new TreeNode(showName);
                foreach(var cd in childDir)
                {
                    tn.Nodes.Add(buildTree((path + "\\" + cd).Replace("\\\\", "\\"), cd));
                }
                return tn;
            }
            else
            {
                return new TreeNode(showName);
            }


        }

        private List<string> getChildDir(string path)
        {
            List<string> listr = new List<string>();
            foreach (var fr in lfr)
            {
                if (fr.path == path)
                {
                    foreach (var item in fr.listObj)
                    {

                        if (!item.isFile()&&item.getName()!=".." && item.getName() != ".")
                        {
                            listr.Add(item.getName());
                        }

                    }
                    break;
                }
            }
            return listr;
        }

        private string getParentPath(string path)
        {
            string returnStr = "";

            int start = path.Length-1;
            if (path[start] == '\\'&& returnStr.IndexOf('\\') >2)
            {
                start--;
            }

            for(int i = start; i >= 0; i--)
            {
                if (path[i] == '\\')
                {
                    returnStr= path.Substring(0, i);
                    break;
                }
            }

            //处理磁盘根目录
            if (returnStr.IndexOf('\\') == -1)
            {
                returnStr += "\\";
            }

            return returnStr;
        }

        private void tvTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            tbPath.Text = e.Node.FullPath.Replace("\\\\", "\\");
            bindData(tbPath.Text);
        }
    }
}
