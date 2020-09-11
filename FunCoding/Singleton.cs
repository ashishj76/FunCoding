using System;
using System.Collections.Generic;
using System.Text;

namespace FunCoding
{
    public class Singleton
    {
        private static Singleton instance = null;
        public Singleton()
        {
            Console.Write("creating instance\n");
        }
        
        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                    instance = new Singleton();
                return instance;
            }
        }

        public void printMessage()
        {
            Console.WriteLine("printing message\n");
        }

    }

}
