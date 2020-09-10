using System;
using System.Collections.Generic;
using System.Linq;

namespace FunCoding
{
    //Given an array of integers and a value, determine if there are any two integers in the array whose sum is equal 
    //to the given value. Return true if the sum exists and return false if it does not. Consider this array and the target sums:
    //5,7,1,2,8,4,3 Target sum = 10 (7+3, 2+8)
    class SumOfTwoIntegers
    {
        public void Execute(List<int> input, int sum)
        {
            input.ForEach(i =>
                        input.ForEach(j =>
                        {
                            if (i!=j && (i + j) == sum)
                            {
                                Console.WriteLine("sum of {0} and {1} is {2}\n", i.ToString(), j.ToString(), sum.ToString());
                            }
                        }) );
        }
    }
}
