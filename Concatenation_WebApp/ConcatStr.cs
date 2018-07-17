using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Concatenation_WebApp
{
    public class ConcatStr
    {
        string[] str = new string[20];
        public string[] Str
        {
            set { str = value; }
            get { return str; }
        }
        public string[] Concat()
        {
            UsedStrs usedS = new UsedStrs();
            string[] newStrs = new string[200];
            var except = str;
            string newStr;
            int len, i = 0;

            foreach (string strNotUsedAsBeginning in except)
            {
                if (strNotUsedAsBeginning != "" && strNotUsedAsBeginning != null)
                {
                    newStr = strNotUsedAsBeginning;
                    len = newStr.Length;
                    usedS.UsedSet = strNotUsedAsBeginning;
                    except = (from q in str where str.Except(usedS.UsedGet).Contains(q) select q).ToArray();
                    foreach (string strNotUsedWithThisBeginning in except)
                    {
                        if (strNotUsedWithThisBeginning != "")
                        {
                            newStr += strNotUsedWithThisBeginning;
                            newStrs[i] = newStr;
                            i++;
                            newStr = newStr.Remove(len);
                        }
                    }
                }
            }
            return newStrs;
        }
    }
}