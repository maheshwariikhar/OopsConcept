using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    internal class AlternativeArray
    {

        static void Main()
        {
            int[] numbers = { 10, 20, 30, 40, 50 };
            Console.WriteLine("Original Array:");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("\n\nAlternative Array:");
            for (int i = 0; i < numbers.Length; i += 2)
            {
                Console.Write(numbers[i] + " ");// console.write:- print the output on the same line
            }

        }
    }
}

