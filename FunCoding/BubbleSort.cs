using System;
using System.Collections.Generic;
using System.Text;

namespace FunCoding
{
    class BubbleSort
    {
        public void Execute(int[] s)
        {
            Console.WriteLine("Original array :");
            foreach (int aa in s)
                Console.Write(aa + " "); 

            for (int i =0;i<s.Length-1;i++)
            {
                for(int j=0; j<s.Length-1;j++)
                {
                    if(s[j] > s[j+1])
                    {
                        int t = s[j + 1];
                        s[j + 1] = s[j];
                        s[j] = t;
                    }
                }
            }

            Console.WriteLine("\n" + "Sorted array :");
            foreach (int aa in s)
                Console.Write(aa + " ");
            Console.Write("\n");

        }
    }
}
