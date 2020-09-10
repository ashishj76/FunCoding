using System;
using System.Collections.Generic;
using System.Text;

namespace FunCoding
{
    class FizzBuzz
    {
        public void Fizzbuzz(int num)
        {
            var ret = new List<String> ();
            int i = 1;
            while (i <= num)
            {
                if (i % 15 == 0)
                {
                    Console.Write("FizzBuzz\n");
                } else if (i % 3 == 0)
                {
                    Console.Write("Fizz\n");
                }
                else if (i % 5 == 0)
                {
                    Console.Write("Buzz\n");
                }
                else
                {
                    Console.Write(i.ToString()+ "\n");
                }
                i++;
            }
        }
    }
}
