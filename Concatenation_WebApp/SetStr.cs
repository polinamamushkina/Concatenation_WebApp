using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Concatenation_WebApp
{
    public class SetStr : ConcatStr
    {
        public void SetStrFromWeb(string s)
        {
            string[] words = new string[20];
            words = s.Split(' ');
            this.Str = words;
        }
    }
}