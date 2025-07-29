using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    internal class SumArray
    {
        static void Main()
        {
            int[] values = { 5, 7, 9, 11, 13, 15 };
            int sum = 0; //Total value of the array element
            for (int i = 0; i < values.Length; i++)
            {
                sum += values[i]; // Add each element of the array variable
            }
            Console.WriteLine("Sum of Array values is:" + sum);

        }
    }
}
