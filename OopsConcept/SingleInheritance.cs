using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    class Person // Base class or parent class or super class
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public void DisplayPerson()
        {
            Console.WriteLine(" Name:" + Name);
            Console.WriteLine(" Age:" + Age);
        }
    }

    class Student : Person // child class or derived class subclass
    {
        public int Id { get; set; }
        public void DisplayStudent()
        {
            Console.WriteLine(" Id:" + Id);
        }
    }
    internal class SingleInheritance
    {
        static void Main()
        {
            Student s1 = new Student();
            s1.Name = "Mahi";
            s1.Age = 22;
            s1.Id = 1;
            s1.DisplayPerson();
            s1.DisplayStudent();
        }
    }
}