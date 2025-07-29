using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    internal class SmallestArray
    {


        static void Main()
        {
            int[] numbers = { 10, 20, 30, 8, 40, 50 };
            int smallest = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < smallest)
                {
                    smallest = numbers[i];
                }
            }
            Console.WriteLine("Smallest number in the array is:" + smallest);

        }
    }

}

