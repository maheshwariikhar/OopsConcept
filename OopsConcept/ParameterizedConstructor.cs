using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    public class ParameterizedConstructorExp
    {
        public string name { get; set; }
        public int age { get; set; }

        public ParameterizedConstructorExp( string Name, int Age)
        {
            name = Name;
            age = Age;
        }
        public void DisplayInfo()
        {
            Console.WriteLine("Parameterized Constructor.....");
            Console.WriteLine($"Name:{name}, Age:{age}");
        }
    }
    internal class ParameterizedConstructor
    {
        static void Main()
        {
            ParameterizedConstructorExp p1 = new ParameterizedConstructorExp("Mahi", 25);
            p1.DisplayInfo();
        }
    }
}
