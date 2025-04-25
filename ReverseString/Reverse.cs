// Creator: Ryder Held
// Date: 2/25/2025
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    public class Reverse
    {
        public char[] StringReverse(char[] s)
        {
            int l = 0;
            int r = s.Count() - 1;

            while (l < r)
            {
                char temp = s[l];
                s[l++] = s[r];
                s[r--] = temp;
            }
            
            return s;
        }
    }
}
