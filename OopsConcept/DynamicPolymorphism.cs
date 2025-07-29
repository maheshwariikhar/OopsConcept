using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    class Vehicle
    {
        public virtual void StartEngine()
        {
            Console.WriteLine("Vehicle engine Started");
        }
    }
    class Mycar : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Car engine Started");
        }
    }
    class Truck : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Truck engine Started");
        }
    }
    internal class DynamicPolymorphism
    {
        static void Main()
        {
            Vehicle v1 = new Vehicle();
            Vehicle v2 = new Mycar();
            Vehicle v3 = new Truck();
            v1.StartEngine();
            v2.StartEngine();
            v3.StartEngine();
        }
    }
}
