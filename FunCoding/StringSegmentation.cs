using System;
using System.Collections.Generic;
using System.Text;

namespace FunCoding
{
    class StringSegmentation
    {
        public void Execute(string input, HashSet<string> hash)
        {
            string[] str = input.Split(' ');
            bool notFound=false;
            for(int i=0; i <str.Length;i++)
            {
                if(!hash.Contains(str[i]))
                {
                    Console.Write("segement {0} not found\n", str[i]);
                    notFound = true;
                    break;
                }
            }

            if (!notFound)
            { Console.WriteLine("string found in dictionary\n"); }
        }
    }
}
