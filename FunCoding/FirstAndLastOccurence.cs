using System;
using System.Collections.Generic;
using System.Text;

namespace FunCoding
{
    /*Given a sorted array with possibly duplicate elements, the task is to find indexes of first and last occurrences of an element x in the given array.
      input : arr[] = {1, 3, 5, 5, 5, 5, 67, 123, 125}    
        x = 5
       Output : First Occurrence = 2
                Last Occurrence = 5
    Input : arr[] = {1, 3, 5, 5, 5, 5, 7, 123, 125 }    
        x = 7
    Output : First Occurrence = 6
             Last Occurrence = 6
    */
    class FirstAndLastOccurence
    {
        public void Execute(int[] arr, int key)
        {
            int count = arr.Length;
            int lowIndex = 0;
            int highIndex = 0;
            for(int i=1;i<=count;i++)
            {
                if (key != arr[i])
                    continue;
                if(lowIndex==0)
                    lowIndex = i;
                 highIndex =i;
            }
            if (lowIndex > 0)
            {
                Console.WriteLine("LowIndex for key:{0} is {1}", key, lowIndex);
                Console.WriteLine("HighIndex for key:{0} is {1}", key, highIndex);
            }
            else
                {
                Console.WriteLine("Not found");
            }
        }
    }
}
