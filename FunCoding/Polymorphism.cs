using System;
using System.Collections.Generic;
using System.Text;

namespace FunCoding
{
    class Polymorphism
    {
        public class Animal
        {
            public virtual void AnimalMakeSound()
            {
                Console.WriteLine("Animal makes sound...");
            }
        }

        public class Dog:Animal
        {
            public override void AnimalMakeSound()
            {
                Console.WriteLine("Dog makes bow bow sound...");
            }
        }

        public class Cat : Animal
        {
            public override void AnimalMakeSound()
            {
                Console.WriteLine("Cat makes meow meow sound...");
            }
        }
    }
}
