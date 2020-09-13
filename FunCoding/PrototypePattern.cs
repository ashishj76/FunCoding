using System;
using System.Collections.Generic;
using System.Text;

namespace FunCoding
{
    //Prototype pattern falls in the section of creational pattern.It gives us a way to create 
    //new objects from the existing instance of the object. In one sentence we clone the existing 
    //object with its data.By cloning any changes to the cloned object does not affect the original 
    //object value.
    class PrototypePattern
    {
        public class Customer
        {
            public string firstName;
            public string lastName;
            public Customer getClone()
            {
                return (Customer) this.MemberwiseClone();
            }
        }
    }
}
