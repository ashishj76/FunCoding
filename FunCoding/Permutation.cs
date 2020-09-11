using System;
using System.Collections.Generic;
using System.Text;

namespace FunCoding
{
    class Permutation
    {
        static int permcount;
        public void Execute(string rest, string prefix="")
        {
            if (string.IsNullOrEmpty(rest))
            {
                permcount++;
                Console.WriteLine("{0} : {1}", permcount, prefix);
            }

            // Each letter has a chance to be permutated
            for (int i = 0; i < rest.Length; i++)
            {
                Execute(rest.Remove(i, 1), prefix + rest[i]);
            }
        }
    }
}
