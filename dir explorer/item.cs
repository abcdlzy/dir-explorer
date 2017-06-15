using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace dir_explorer
{
    public class item
    {
        string time;
        string info;
        string name;
        bool isVaild;

        public bool IsVaild { get => isVaild; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="source">dir的单行信息</param>
        public item(string source)
        {
            //检测是不是正常的item
            if(source[0]==' ')
            {
                isVaild = false;
                return;
            }

            string replace = source.Replace('\t', ' ');
            replace= Regex.Replace(replace, "\\s{2,}", " ");
            replace = replace.Trim();
            int spaceCheckCount = 0;
            for (int i = 0; i < replace.Length; i++)
            {
                //12小时制
                bool timeFormat = false;
                if(replace[2].Equals("AM") || replace[2].Equals("PM"))
                {
                    timeFormat = true;
                }

                if (timeFormat&&spaceCheckCount < 3)
                {
                    time += replace[i];
                }
                else if (timeFormat&&spaceCheckCount == 3)
                {
                    info += replace[i];
                }
                if (!timeFormat&&spaceCheckCount < 2)
                {
                    time += replace[i];
                }
                else if (!timeFormat&&spaceCheckCount == 2)
                {
                    info += replace[i];
                }
                else
                {
                    name += replace[i];
                }

                if (replace[i] == ' ')
                {
                    spaceCheckCount++;
                }
            }

            time = time.Trim();
            info = info.Trim();
            name = name.Trim();
            isVaild = true;
        }

        /// <summary>
        /// 获取是否是文件
        /// </summary>
        /// <returns></returns>
        public bool isFile()
        {
            return info != "<DIR>";
        }

        /// <summary>
        /// 获取文件大小，如果不是文件，则返回0
        /// </summary>
        /// <returns>文件大小</returns>
        public int getSize()
        {
            if (!isFile())
            {
                return 0;
            }
            else
            {
                string s = info.Replace(",","");
                int returnVal = 0;
                int.TryParse(s,out returnVal);
                return returnVal;
            }
        }

        /// <summary>
        /// 获取文件或文件夹时间
        /// </summary>
        /// <returns></returns>
        public string getTime()
        {
            return time;
        }

        /// <summary>
        /// 获取文件夹或文件的名称
        /// </summary>
        /// <returns></returns>
        public string getName()
        {
            return name;
        }

        public string getInfo()
        {
            return info;
        }

    }
}
