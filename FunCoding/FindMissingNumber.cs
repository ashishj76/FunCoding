using System;
using System.Collections.Generic;
using System.Linq;

namespace FunCoding
{
    class FindMissingNumber
    {
        public void Execute(List<int> input)
        {
            int total = input.AsQueryable().Sum();
            int length = input.Count()+1;
            int originalTotal = (length * (length + 1)) / 2;
            Console.WriteLine("Missing Number is : " + (originalTotal - total).ToString());
        }
    }
}
