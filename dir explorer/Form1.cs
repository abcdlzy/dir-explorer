using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
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
            cbEncoding.SelectedIndex=0;
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            DialogResult result = ofdSource.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = ofdSource.FileName;
                tbReadFile.Text = file;
                lfr = new List<FolderResult>();
                try
                {
                    if (cbEncoding.SelectedItem.ToString() == "Default")
                    {
                        nowFileText = File.ReadAllText(file, Encoding.Default);
                    }
                    else if (cbEncoding.SelectedItem.ToString() == "UTF8")
                    {
                        nowFileText = File.ReadAllText(file, Encoding.UTF8);
                    }
                    else if (cbEncoding.SelectedItem.ToString() == "Unicode")
                    {
                        nowFileText = File.ReadAllText(file, Encoding.Unicode);
                    }
                    else if (cbEncoding.SelectedItem.ToString() == "ASCII")
                    {
                        nowFileText = File.ReadAllText(file, Encoding.ASCII);
                    }
                    else if (cbEncoding.SelectedItem.ToString() == "BigEndianUnicode")
                    {
                        nowFileText = File.ReadAllText(file, Encoding.BigEndianUnicode);
                    }
                    else if (cbEncoding.SelectedItem.ToString() == "UTF7")
                    {
                        nowFileText = File.ReadAllText(file, Encoding.UTF7);
                    }
                    else if (cbEncoding.SelectedItem.ToString() == "UTF32")
                    {
                        nowFileText = File.ReadAllText(file, Encoding.UTF32);
                    }
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
            else if (gvRs.Rows[e.RowIndex].Cells[1].Value.ToString() == "<SYMLINKD>" || gvRs.Rows[e.RowIndex].Cells[1].Value.ToString() == "<JUNCTION>")
            {
                string linkpath = gvRs.Rows[e.RowIndex].Cells[2].Value.ToString();
                int start = linkpath.IndexOf('[');
                int end = linkpath.IndexOf(']');

                
                string subpath = linkpath.Substring(start + 1, end - start - 1);

                //解决盘符大小写问题
                char[] cpath = subpath.ToCharArray();
                cpath[0]= tbPath.Text[0];
                tbPath.Text = new string(cpath);



                tbPath.Text = tbPath.Text.Replace("\\\\", "\\");
                bindData(tbPath.Text);
            }
            //剪贴板
            else
            {
                tbclip.Text = tbPath.Text + "\\" + gvRs.Rows[e.RowIndex].Cells[2].Value.ToString();
                tbclip.Text = tbclip.Text.Replace("\\\\", "\\");
                try
                {
                    Clipboard.SetText(tbclip.Text);
                    lbClipTips.Text = "";
                }
                catch(Exception ex)
                {
                    lbClipTips.Text = ex.Message;
                }
                
            }
        }

        private void bindTree()
        {
            if (lfr.Count > 0)
            {
                tvTree.Nodes.Clear();
                tvTree.Nodes.Add(buildTree(lfr[0].path, lfr[0].path));
            }
        }

        private TreeNode buildTree(string path,string showName)
        {
            var childDir = getChildDir(path);
            if (childDir.Count > 0)
            {
                TreeNode tn = new TreeNode(showName);

                Parallel.ForEach(childDir, cd =>
                {
                    TreeNode getTree =buildTree((path + "\\" + cd).Replace("\\\\", "\\"), cd);
                    lock (this)
                    {
                        tn.Nodes.Add(getTree);
                    }
                });
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

        private void btnsearch_Click(object sender, EventArgs e)
        {
            bindSearch(tbsearch.Text);
        }

        private void bindSearch(string key)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("时间", typeof(String));
            dt.Columns.Add("信息", typeof(String));
            dt.Columns.Add("名称", typeof(String));
            dt.Columns.Add("路径", typeof(String));

            List<string> listKey = new List<string>();
            if (key.IndexOf('|') != -1)
            {
                string[] keys = key.Split('|');
                foreach (var k in keys)
                {
                    if (cbcase.Checked)
                    {
                        listKey.Add(k.ToLower());
                    }
                    else
                    {
                        listKey.Add(k);
                    }

                }
            }
            else
            {
                if (cbcase.Checked)
                {
                    listKey.Add(key.ToLower());
                }
                else
                {
                    listKey.Add(key);
                }
            }

            foreach (var folderRes in lfr)
            {
                foreach (var itemObj in folderRes.listObj)
                {
                    
                    foreach(var lk in listKey)
                    {
                        string filename = itemObj.getName();
                        if (cbcase.Checked)
                        {
                            filename=filename.ToLower();
                            
                        }
                        if (lk.IndexOf('*') != -1)
                        {
                            string[] lkArray = lk.Split('*');
                            string subfilnename = filename;
                            for(int i = 0; i < lkArray.Length; i++)
                            {
                                if (i != lkArray.Length - 1)
                                {
                                    if (subfilnename.IndexOf(lkArray[i]) == -1)
                                    {
                                        break;
                                    }
                                    int startPos = subfilnename.IndexOf(lkArray[i]) + lkArray[i].Length;
                                    int cutLength = subfilnename.Length - startPos;
                                    if (subfilnename.Length < startPos)
                                    {
                                        break;
                                    }
                                    subfilnename = subfilnename.Substring(startPos, cutLength);
                                    if (subfilnename.Length == 0)
                                    {
                                        break;
                                    }
                                }
                                else
                                {
                                    if (lkArray[i] == "")
                                    {
                                        DataRow dr = dt.NewRow();
                                        dr["时间"] = itemObj.getTime();
                                        dr["信息"] = itemObj.getInfo();
                                        dr["名称"] = itemObj.getName();
                                        dr["路径"] = (folderRes.path + "\\" + itemObj.getName()).Replace("\\\\", "\\");
                                        dt.Rows.Add(dr);
                                    }
                                    else
                                    {
                                        if (subfilnename.IndexOf(lkArray[i]) == -1)
                                        {
                                            break;
                                        }
                                        int startPos = subfilnename.IndexOf(lkArray[i]) + lkArray[i].Length;
                                        int cutLength = subfilnename.Length - startPos;

                                        if (subfilnename.Length < startPos)
                                        {
                                            break;
                                        }
                                        subfilnename = subfilnename.Substring(startPos, cutLength);
                                        if (subfilnename.Length == 0)
                                        {
                                            DataRow dr = dt.NewRow();
                                            dr["时间"] = itemObj.getTime();
                                            dr["信息"] = itemObj.getInfo();
                                            dr["名称"] = itemObj.getName();
                                            dr["路径"] = (folderRes.path + "\\" + itemObj.getName()).Replace("\\\\", "\\");
                                            dt.Rows.Add(dr);
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            if (filename.IndexOf(lk) != -1)
                            {
                                DataRow dr = dt.NewRow();
                                dr["时间"] = itemObj.getTime();
                                dr["信息"] = itemObj.getInfo();
                                dr["名称"] = itemObj.getName();
                                dr["路径"] = (folderRes.path + "\\" + itemObj.getName()).Replace("\\\\", "\\");
                                dt.Rows.Add(dr);
                            }
                        }
                    }
                }
            }

            gvSearch.DataSource = dt;

        }

        private void gvSearch_DataSourceChanged(object sender, EventArgs e)
        {
            gvSearch.Columns[0].Width = 150;
            gvSearch.Columns[1].Width = 150;
            gvSearch.Columns[2].Width = 300;
            gvSearch.Columns[3].Width = 500;
        }

        private void gvSearch_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbSearchClip.Text =  gvSearch.Rows[e.RowIndex].Cells[3].Value.ToString();
            try
            {
                Clipboard.SetText(tbSearchClip.Text);
                lbSearchTips.Text = DateTime.Now+ ":已复制到剪贴板.";
            }
            catch (Exception ex)
            {
                lbSearchTips.Text = ex.Message;
            }
        }

        private void tbsearch_MouseMove(object sender, MouseEventArgs e)
        {
            toolTipSearch.Show("使用 * 模糊搜索，使用 | 搜索多个", tbsearch);
        }
    }
}
