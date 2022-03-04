using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session04
{
    internal class ex_1
    {
        public string Reverse(string text)
        {
            string OgName = string.Empty;
            string reverse = string.Empty;
            OgName = text;
            for (int i = OgName.Length - 1; i >= 0; i--)
            {
                reverse += OgName[i];
            }
            return reverse;
        }
    }
}
