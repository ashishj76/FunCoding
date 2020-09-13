using System;
using System.Collections.Generic;
using System.Text;

namespace FunCoding
{
    class FactoryPattern
    {
       public interface IFactory
        {
            void Drive(int miles);
        }

        public class Scooter:IFactory
        {
            public void Drive(int miles)
            {
                Console.WriteLine("Scooter drives for miles : {0}", miles);
            }
        }

        public class Bike : IFactory
        {
            public void Drive(int miles)
            {
                Console.WriteLine("Bike drives for miles : {0}", miles);
            }
        }

        public abstract class VehicleFactory
        {
            public abstract IFactory GetVehicle(string vehicle);            
        }

        public class ConcreteFactory : VehicleFactory
        {
            public override IFactory GetVehicle(string vehicle)
            {
                switch (vehicle)
                {
                    case "Scooter":
                        return new Scooter();
                    case "Bike":
                        return new Bike();
                    default:
                        throw new ApplicationException(string.Format("Vehicle '{0}' cannot be created", vehicle));
                }
            }
        }
    }
}
