using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    public class DefaultConstructorExamp
    {
        public string name;
        public int age;

        //  Default Constructor 
        public DefaultConstructorExamp()
        {
            name = "Mahi";
            age = 25;
        }

        public void Display()
        {
            Console.WriteLine("Default Constructor......");
            Console.WriteLine($"Name:{name}, Age:{age}");
        }
    }
    internal class DefaultConstructor
    {
        static void Main()
        {
            DefaultConstructorExamp d1 = new DefaultConstructorExamp();
            d1.Display();

        }
    }
}
