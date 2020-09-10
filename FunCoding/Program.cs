using System;
using System.Linq;
using System.Collections.Generic;


namespace FunCoding
{
    class Program
    {
        static void Main(string[] args)
        {
            CallFizzBuzz();
            CallPalindrome();
            CallFindMissingNumber();
        }

        private static void CallFizzBuzz()
        {
            var obj = new FizzBuzz();
            obj.Execute(5);
        }

        private static void CallPalindrome()
        {
            var obj = new Palindrome();
            obj.Execute("313");
        }

        private static void CallFindMissingNumber()
        {
            var obj = new FindMissingNumber();
            obj.Execute(new List<int>() { 3,7,1,2,8,4,5});
        }
    }
}
