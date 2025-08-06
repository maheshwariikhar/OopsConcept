using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    public delegate void Arith(int a, int b);
    
    class Calculator1
    {
        public void Add(int a, int b)
        {
            Console.WriteLine("Addition is:" +(a + b));
        }
        public void Sub(int a, int b)
        {
            Console.WriteLine("Substraction is:" + (a - b));
        }
        public void Multi(int a, int b)
        {
            Console.WriteLine("Multiplication:" + (a * b));
        }
        public void Div(int a, int b)
        {
            Console.WriteLine("Division is:" + (a / b));
        }
    }
    internal class MultiDelegates
    {
        static void Main()
        {
            Calculator1 cals = new Calculator1();
            Arith a1 = cals.Add;
            a1 += cals.Sub;
            a1 += cals.Multi;
            a1 += cals.Div;
            a1(20, 15);


        }






    }
}
