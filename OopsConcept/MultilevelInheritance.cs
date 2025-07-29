using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    class persion
    {
        public string Name;
        public int Age;
        public void DisplayPersion()
        {
            Console.WriteLine("Name:" + Name);
            Console.WriteLine("Age:" + Age);
        }
    }
    class Teacher : persion
    {
        public string Subject;
        public void DisplayTeacher()
        {
            Console.WriteLine("Subject:" + Subject);
        }
    }
    class Principal : Teacher
    {
        public string SchoolName;
        public void DisplayPrincipal()
        {
            Console.WriteLine("School_Name:" + SchoolName);
        }
    }
    internal class MultilevelInheritance
    {
        static void Main()
        {
            Principal p1 = new Principal();
            p1.Name = "Mr Xyz";
            p1.Age = 30;
            p1.Subject = "Test";
            p1.SchoolName = "Abc";
            p1.DisplayPersion();
            p1.DisplayTeacher();
            p1.DisplayPrincipal();


        }
    }
    }


