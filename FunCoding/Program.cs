using System;
using System.Linq;
using System.Collections.Generic;


namespace FunCoding
{
    class Program
    {
        static void Main(string[] args)
        {
            BuilderPattern();
            FactoryPattern();
            Polymorphism();
            Permutation();
            CountCoins();
            ReverseString();
            CallSingleton();
            StringSegmentation();
            BubbleSort(new int[] { 3, 7, 1, 2, 8, 4, 5 });
            MergeSortedList();
            SumOfTwoIntegers();
            FizzBuzz(5);
            Palindrome("313");
            FindMissingNumber(new List<int>() { 3, 7, 1, 2, 8, 4, 5 });
        }

        private static void BuilderPattern()
        {
            Console.WriteLine("---Builder Pattern---\n");
            var pdf = new BuilederPattern.PDFReport();
            var excel = new BuilederPattern.ExcelReport();
            var director = new BuilederPattern.ReoprtDirector();

            var report = director.GenerateReport(pdf);
            Console.WriteLine(report.Header);
            Console.WriteLine(report.Content);
            Console.WriteLine(report.Footer);

            report = director.GenerateReport(excel);
            Console.WriteLine(report.Header);
            Console.WriteLine(report.Content);
            Console.WriteLine(report.Footer);
        }

        private static void FactoryPattern()
        {
            Console.WriteLine("---Factory Pattern---\n");
            var factory = new FactoryPattern.ConcreteFactory();
            var scooter = factory.GetVehicle("Scooter");
            scooter.Drive(100);

            var bike = factory.GetVehicle("Bike");
            bike.Drive(10);
        }

        private static void Polymorphism()
        {
            Console.WriteLine("---Polymorphism---\n");
            var animal = new Polymorphism.Animal();
            var dog = new Polymorphism.Dog();
            var cat = new Polymorphism.Cat();
            animal.AnimalMakeSound();
            dog.AnimalMakeSound();
            cat.AnimalMakeSound();
        }

        private static void Permutation()
        {
            Console.WriteLine("---Kth Permutation---\n");
            var obj = new Permutation();
            obj.Execute("abcd");
        }
        private static void CountCoins()
        {
            Console.WriteLine("---Count Coins ---\n");
            var obj = new CountCoins();
            obj.Execute(new int[] {1,2,5 }, 7);
        }
        private static void ReverseString()
        {
            Console.WriteLine("---ReverseString ---\n");
            var obj = new ReverseString();
            obj.Execute("This is the reverse string");
        }
        private static void CallSingleton()
        {
            Console.WriteLine("---Singleton pattern---\n");
            Singleton.Instance.printMessage();
            Singleton.Instance.printMessage();
        }
        private static void StringSegmentation()
        {
            Console.WriteLine("---String Segmentation---\n");
            var obj = new StringSegmentation();
            var input = "apple pie1";
            var hash = new HashSet<string>();
            hash.Add("apple");
            hash.Add("pear");
            hash.Add("pie");
            obj.Execute(input,hash);
        }

        private static void BubbleSort(int[] input)
        {
            Console.WriteLine("---BubbleSort---\n");
            var obj = new BubbleSort();
            obj.Execute(input);
        }

        private static void FizzBuzz(int input)
        {
            Console.WriteLine("---FizzBuzz---\n");
            var obj = new FizzBuzz();
            obj.Execute(input);
        }

        private static void Palindrome(string s)
        {
            Console.WriteLine("---Palindrome---\n");
            var obj = new Palindrome();
            obj.Execute(s);
        }

        private static void FindMissingNumber(List<int> input)
        {
            Console.WriteLine("---Find Missing Number---\n");
            var obj = new FindMissingNumber();
            obj.Execute(input);
        }

        private static void SumOfTwoIntegers()
        {
            Console.WriteLine("---Sum of To Integers---\n");
            var obj = new SumOfTwoIntegers();
            obj.Execute(new List<int>() { 5, 7, 1, 2, 8, 4, 3 }, 10);
        }

        private static void MergeSortedList()
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
