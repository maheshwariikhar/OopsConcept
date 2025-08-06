using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    public delegate void Add(int a, int b);
    public delegate void Sub(int a, int b);

    class Calculator
    {
        public void Addnumber(int a, int b)
        {
            Console.WriteLine("Addition is:" +(a + b));
        }
        public void Subnumber(int a, int b)
        {
            Console.WriteLine("Substraction is:" +(a - b));
        }
    }
    internal class SingleDelegates
    {
        static void Main()
        {
            Calculator cal = new Calculator();
            Add ad = new Add(cal.Addnumber);
            ad(20, 10);
            Sub sb = new Sub(cal.Subnumber);
            sb(30,22);



        }
    }
}
