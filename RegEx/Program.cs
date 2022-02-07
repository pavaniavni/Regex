using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace HandlingRegEx
{
    public class RegEx
    {
        static void Main(string[] args)
        {
            //this will return any pattern line ab,aab,aaab;
            //Regex re = new Regex("a*b");
            //this will return pattern like b,ab
            Regex r = new Regex("a*b?c");
            Match m = r.Match("aaabbcccd");
            if (m.Success)
            {
                Console.WriteLine("Mached the value " + m.Value);
            }
        }
    }
}
