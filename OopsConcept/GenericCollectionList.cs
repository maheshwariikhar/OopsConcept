using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    internal interface GenericCollectionList
    {
        static void Main()
        {
            List<int> myList = new List<int>();
            myList.Add(10);
            myList.Add(20);
            myList.Add(30);
            myList.Add(40);
            myList.Add(50);
            Console.WriteLine("Display After Adding List");
            foreach (int i in myList)
            {
                Console.WriteLine(i);
            }
            // insert element in list
            myList.Insert(1, 60);
            Console.WriteLine("\nDisplay After Insert List");
            foreach (int i in myList)
            {
                Console.WriteLine(i);
            }

            // remove element in list
            myList.Remove(30);
            Console.WriteLine("\nDisplay After Remove List");
            foreach (int i in myList)
            {
                Console.WriteLine(i);
            }
            //myList.Clear();




        }
    }
}
