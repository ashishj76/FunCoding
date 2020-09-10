using System;
using System.Linq;
using System.Collections.Generic;


namespace FunCoding
{
    class Program
    {
        static void Main(string[] args)
        {
            CallBubbleSort(new int[] { 3, 7, 1, 2, 8, 4, 5 });
            CallMergeSortedList();
            CallSumOfTwoIntegers();
            CallFizzBuzz(5);
            CallPalindrome("313");
            CallFindMissingNumber(new List<int>() { 3, 7, 1, 2, 8, 4, 5 });
        }

        private static void CallBubbleSort(int[] input)
        {
            Console.WriteLine("---BubbleSort---\n");
            var obj = new BubbleSort();
            obj.Execute(input);
        }

        private static void CallFizzBuzz(int input)
        {
            Console.WriteLine("---FizzBuzz---\n");
            var obj = new FizzBuzz();
            obj.Execute(input);
        }

        private static void CallPalindrome(string s)
        {
            Console.WriteLine("---Palindrome---\n");
            var obj = new Palindrome();
            obj.Execute(s);
        }

        private static void CallFindMissingNumber(List<int> input)
        {
            Console.WriteLine("---Find Missing Number---\n");
            var obj = new FindMissingNumber();
            obj.Execute(input);
        }

        private static void CallSumOfTwoIntegers()
        {
            Console.WriteLine("---Sum of To Integers---\n");
            var obj = new SumOfTwoIntegers();
            obj.Execute(new List<int>() { 5, 7, 1, 2, 8, 4, 3 }, 10);
        }

        private static void CallMergeSortedList()
        {
            Console.WriteLine("---Merge Sorted List---\n");
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
