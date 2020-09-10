using System;
using System.Linq;
using System.Collections.Generic;


namespace FunCoding
{
    class Program
    {
        static void Main(string[] args)
        {
            CallMergeSortedList();
            CallSumOfTwoIntegers();
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

        private static void CallSumOfTwoIntegers()
        {
            var obj = new SumOfTwoIntegers();
            obj.Execute(new List<int>() { 5, 7, 1, 2, 8, 4, 3 }, 10);
        }

        private static void CallMergeSortedList()
        {
            
            var l1 = new MergeSortedLinkedList.LinkedList();
            l1.Add(new MergeSortedLinkedList.Node("3"));
            l1.Add(new MergeSortedLinkedList.Node("5"));
            l1.Add(new MergeSortedLinkedList.Node("7"));
            l1.Add(new MergeSortedLinkedList.Node("9"));

            var l2 = new MergeSortedLinkedList.LinkedList();
            l2.Add(new MergeSortedLinkedList.Node("2"));
            l2.Add(new MergeSortedLinkedList.Node("4"));
            l2.Add(new MergeSortedLinkedList.Node("6"));
            l2.Add(new MergeSortedLinkedList.Node("8"));

            var obj = new MergeSortedLinkedList.LinkedList();
            obj.Execute(l1.Head,l2.Head);
            obj.printList();
        }
    }
}
