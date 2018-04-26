using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_kepeer_1
{
    class Coding
    {
        public string GetCoding(string line)
        {
            string newline = "";
            char[] chararr;
            int a = 0;
            chararr = line.ToCharArray();
            for (int i = 0; i < chararr.Length; i++)
            {
                a = (int)chararr[i] + 1;
                newline += (char)a;
            }
            return newline;
        }
        public string GetEncoding(string line)
        {
            string newline = "";
            char[] chararr;
            int a = 0;
            chararr = line.ToCharArray();
            for (int i = 0; i < chararr.Length; i++)
            {
                a = (int)chararr[i] - 1;
                newline += (char)a;
            }
            return newline;
        }
    }
}
