using System;
using System.Collections.Generic;
using System.Text;

namespace FunCoding
{
    public class ReverseString
    {
        public void Execute(string input)
        {
            string[] str = input.Split(' ');
            var msg = new StringBuilder();
            Console.Write("Input string : {0}\n", input);
            for (int i=str.Length-1;i>=0;i--)
            {
                msg.Append(str[i]).Append(' ');
            }
            Console.Write("Reversed stringis : {0}\n", msg.ToString());
        }

    }

}
