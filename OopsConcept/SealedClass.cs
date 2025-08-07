using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    public class BaseClass
    {

        public void DisplayBaseInfo()
        {
            Console.WriteLine("This is a Base Class");
        }
    }
    sealed class DerivedClass : BaseClass
    {
        public void DisplayDerivedInfo()
        {
            Console.WriteLine("This is a Derived Class ");
        }
    }
    internal class SealedClass
    {
        static void Main()
        {
            DerivedClass dc = new DerivedClass();
            dc.DisplayBaseInfo();
            dc.DisplayDerivedInfo();

        }
       
    }
}
