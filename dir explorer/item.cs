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

            string[] rArray = replace.Split(' ');

            //12小时制
            bool timeFormat = false;

            if (rArray[2].Length==2)
            {
                char[] time = rArray[2].ToCharArray();
                if(time[0]>='A'&&time[0]<='Z'&& time[1] >= 'A' && time[1] <= 'Z')
                {
                    timeFormat = true;
                }
            }

            for (int i = 0; i < rArray.Length; i++)
            {
                if (timeFormat&&i < 3)
                {
                    time +=(i!=0?" ":"")+ rArray[i];
                }
                else if (timeFormat&&i == 3)
                {
                    info +=rArray[i];
                }
                else if (!timeFormat&&i < 2)
                {
                    time += (i != 0 ? " " : "") + rArray[i];
                }
                else if (!timeFormat&&i == 2)
                {
                    info +=rArray[i];
                }
                else
                {
                    name +=((timeFormat&&i!=4)||(!timeFormat&&i!=3)?" ":"")+ rArray[i];
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
