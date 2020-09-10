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
            while (true)
            {
                if (begin > end)
                {
                    Console.Write("{0} is palindrome\n",s);
                    break;
                }
                char a = s[begin];
                char b = s[end];
                if(char.ToLower(a)!= char.ToLower(b))
                {
                    Console.Write("{0} is not palindrome", s);
                    break;
                }
                begin++;
                end--;
            }
        }
    }
}
