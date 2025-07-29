using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    internal interface Collections
    {
        static void Main()
        {
            Dictionary<string, int> dic = new Dictionary<string, int>();
            dic.Add("Banana", 1);
            dic.Add("Mango", 2);
            dic.Add("Graps", 3);
            dic.Add("Orange", 4);
            dic.Add("Kiwi", 5);
            dic.Add("Cherry", 6);
            dic.Add("Lemon", 7);
            dic.Add("Guava", 8);
            dic.Add("Straberry", 9);
            dic.Add("Watermelon", 10);
            Console.WriteLine("........Display All Dictinary Elements........");

            foreach (KeyValuePair<string, int> element in dic)
            {
                Console.WriteLine($"{element.Key}:{element.Value}");
            }

            dic["Mango"] = 22;
            Console.WriteLine("........Element After Modify........");

            foreach (var item in dic)
            {
                Console.WriteLine($"{item.Key}:{item.Value}");
            }
            dic.Remove("Graps");
            Console.WriteLine("........Removing the Element........");
            foreach (var item in dic)
            {
                Console.WriteLine($"{item.Key}:{item.Value}");

            }
            Console.WriteLine("........Searching Element........");

            if (dic.ContainsKey("Orange"))
            {
                Console.WriteLine("Exit in the dictionary");
            }
            else
            {
                Console.WriteLine("Not Exit in the dictionary");
            }
        }
    }

}


