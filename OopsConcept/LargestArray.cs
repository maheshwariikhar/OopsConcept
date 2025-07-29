using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    internal class LargestArray
    {
        static void Main()
        {
            int[] numbers = { 10, 20, 30, 96, 40, 50 };
            int largest = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > largest)
                {
                    largest = numbers[i];
                }
            }
            Console.WriteLine("Largest number in the array is:" + largest);

        }
    }
}
