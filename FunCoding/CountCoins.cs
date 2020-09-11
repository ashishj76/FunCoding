using System;
using System.Collections.Generic;
using System.Text;

namespace FunCoding
{
    public class CountCoins
    {
        //All possible combinations for given amount = 15, coin types=1 6 7 
        //1) 1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,
        //2) 1,1,1,1,1,1,1,1,1,6,
        //3) 1,1,1,1,1,1,1,1,7,
        //4) 1,1,1,6,6,
        //5) 1,1,6,7,
        //6) 1,7,7,
        public void Execute(int[] arr, int sum)
        {
            if (sum < 0)
                Console.Write("sum is 0");

            if (arr == null || arr.Length == 0)
                Console.Write("empty array");

            int[] outarray = new int[sum + 1];
            outarray[0] = 1;

            for (int i=0;i<arr.Length;i++)
            {
                for(int j=arr[i];j<=sum;j++)
                {
                    outarray[j] += outarray[j - arr[i]];
                }
            }

            Console.Write("Total Count Combination is {0}\n", outarray[sum]);
            
        }

    }

}
