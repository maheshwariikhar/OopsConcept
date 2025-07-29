using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    internal interface NonGenericCollection
    {
        static void Main()
        {
            ArrayList list = new ArrayList();
            list.Add("1");
            list.Add("Mahi");
            list.Add("2");
            list.Add("Rani");
            list.Add("8563252154");
            list.Add("3");
            list.Add("Sandy");
            list.Add("7276410450");
            list.Add("4");
            list.Add("Vivek");
            list.Add("pune");
            Console.WriteLine("Display After Adding Array List");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            list.Remove(2);
            Console.WriteLine("\nDisplay After Removing ArrayList");
            foreach (var item in list)
            {
                Console.WriteLine(item);

            }

            //HashTable
            Hashtable MyHashtable = new Hashtable();
            MyHashtable.Add(1, "Pune");
            MyHashtable.Add(2, "Mumbai");
            MyHashtable.Add(3, "Sangadi");
            MyHashtable.Add(4, "Sakoli");
            MyHashtable.Add(5, "Nagpur");
            Console.WriteLine("Display After Adding Hashtable");
            foreach (DictionaryEntry entry in MyHashtable)
            {
                Console.WriteLine($"Key:{entry.Key},value:{entry.Value}");
            }
            //remove Hashtable
            MyHashtable.Remove(2);
            Console.WriteLine("\nDisplay After Remove Hashtable");
            foreach (DictionaryEntry item in MyHashtable)
            {
                Console.WriteLine($"Key:{item.Key},value:{item.Value}");

            }
            //modify hashtable
            MyHashtable["1"] = "6";
            Console.WriteLine("\nDisplay After modify Hashtable");
            foreach (DictionaryEntry entry in MyHashtable)
            {
                Console.WriteLine($"Key:{entry.Key},value:{entry.Value}");


            }







        }
    }
}
