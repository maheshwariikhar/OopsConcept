using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    internal class Arrays
    {
        static void Main()
        {
            // Single arrays
            //int[] roll_number = { 101, 102, 103, 104 };
            //string[] name = { "mahi", "Ruhi", "Rani", "Sonu" };
            //roll_number[0] = 101;
            //roll_number[1] = 102;
            //roll_number[2] = 103;
            //roll_number[3] = 104;
            //name[0] = "Mahi";
            //name[1] = "Ruhi";
            //name[2] = "Rani";
            //name[3] = "Sonu";

            //for (int i = 0; i <= name.Length; i++)
            //{
            //Console.WriteLine(name[i]);


            /* foreach (string item in name)
             {
              Console.WriteLine(item);



             }*/

            //Multidimensinal Arrays
            int[,] matrix = new int[,]
            {
                {1,2,3, },
                {4,5,6, },
                {5,6,7 }
            };
            Console.WriteLine("Elements at(0,0):" + matrix[0, 0]);
            Console.WriteLine("Elements at(0,1):" + matrix[0, 1]);


        }
    }
}

