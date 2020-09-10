using System;
using System.Collections.Generic;
using System.Linq;

namespace FunCoding
{
    //You are given an array of positive numbers from 1 to n, such that all numbers from 1 to n 
    //are present except one number x.You have to find x. The input array is not sorted. 
    //Look at the below array and give it a try before checking the solution.
    //3,7,1,2,8,4,5 n = 8 missing number = 6
    class FindMissingNumber
    {
        public void Execute(List<int> input)
        {
            int total = input.AsQueryable().Sum();
            int length = input.Count()+1;
            int originalTotal = (length * (length + 1)) / 2;
            Console.WriteLine("Missing Number is :{0} \n" ,(originalTotal - total).ToString());
        }
    }
}
