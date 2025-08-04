using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    public class CopyConstructorExample
    {
        public string name { get; set; }
        public int age { get; set; }

        public string Newname { get; set; }
        public int NewAge { get; set; }

        // parameterized Constructor
        public CopyConstructorExample(string Name, int Age)
        {
            name = Name;
            age = Age;

        }
        // copy Constructor
        public CopyConstructorExample(CopyConstructorExample copy)
        {
            Newname = copy.name;
            NewAge = copy.age;

        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Name:{name}, Age:{age}");

        }
        public void DisplayInfoNew()
        {
            Console.WriteLine("Copy Constructor......");
            Console.WriteLine($"Name:{Newname}, Age:{NewAge}");
        }
        
    }

    internal class CopyConstructor
    {
        static void Main()
        {
            CopyConstructorExample obj = new CopyConstructorExample("Mahi", 25);
            obj.DisplayInfo();

            CopyConstructorExample obj2 = new CopyConstructorExample(obj);
            obj2.DisplayInfoNew();


        }
    }
}
