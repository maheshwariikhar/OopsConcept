using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    internal class NumberOfElements
    {
        static void Main()
        {
            int[] numbers = { 10, 20, 30, 40, 50 };
            Console.WriteLine("Array Elemnts:");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("\n\nTotal Number of Elements in the Array:" + numbers.Length);


        }
    }
}
