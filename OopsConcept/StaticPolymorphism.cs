using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{

    class Calculators
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
        public double Add(double a, double b)
        {
            return a - b;
        }
    }
    internal class StaticPolymorphism
    {
        static void Main()
        {
            Calculators cal = new Calculators();
            // calling overloading method
            int sum = cal.Add(15, 10);
            int sum1 = cal.Add(3, 4, 6);
            double sum2 = cal.Add(5.5, 3);
            Console.WriteLine($"Sum of two integers:" + sum);
            Console.WriteLine($"Sum of three integers:" + sum1);
            Console.WriteLine($"sub of  double:" + sum2);





        }









    }
}

