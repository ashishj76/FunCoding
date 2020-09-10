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
    }
}
