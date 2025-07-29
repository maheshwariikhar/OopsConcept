using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    internal class Operators
    {
        static void Main()
        {
            //Arithmetic operators
            int p = 30;
            int q = 15;
            Console.WriteLine("Arithmetic Oprators");
            Console.WriteLine($"Addition is:{p + q}");
            Console.WriteLine($"Substraction is:{p - q}");
            Console.WriteLine($"Multiplication is:{p * q}");
            Console.WriteLine($"Division is:{p / q}");
            Console.WriteLine($"Mod is:{p % q}\n");

            // Relational Operators or Comparision
            Console.WriteLine("Relational Operators/Comparision");
            Console.WriteLine($"p==q is:{p == q}");
            Console.WriteLine($"p!=q is:{p != q}");
            Console.WriteLine($"p>q is:{p > q}");
            Console.WriteLine($"p<q is:{p < q}");
            Console.WriteLine($"p>=q is:{p >= q}");
            Console.WriteLine($"p<=q is:{p <= q}");
        }
    }
}
