using System;
using System.Collections.Generic;
using System.Text;

namespace FunCoding
{
    class Palindrome
    {
        public void Execute(string s)
        {
            var ret = new List<String> ();
            int begin = 0;
            int end = s.Length - 1;
            bool result = true;
            while(true)
            {
                if (begin > end)
                {
                    Console.Write("string is palindrome");
                    break;
                }
                char a = s[begin];
                char b = s[end];
                if(char.ToLower(a)!= char.ToLower(b))
                {
                    Console.Write("string is not palindrome");
                    break;
                }
                begin++;
                end--;
            }
        }
    }
}
