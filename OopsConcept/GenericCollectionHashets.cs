using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    internal interface GenericCollectionHashets
    {
        static void Main()
        {
            HashSet <string> subject = new HashSet <string> ();
            subject.Add("Math");
            subject.Add("Science");
            subject.Add("English");
            subject.Add("Marathi");
            subject.Add("Hindi");
            Console.WriteLine("Display after Hashet element add");
            foreach(string sub in subject)
            {
                Console.WriteLine(sub);
            }
            // Removing Hashet
            subject.Remove("Science");
            Console.WriteLine("\nAfter Removing Hashet");
            foreach(string sub in subject)
            {
                Console.WriteLine(sub);
            }

            HashSet<int> set1 = new HashSet<int> { 1, 2, 3, 4,6 };
            HashSet<int> set2 = new HashSet<int> { 5, 7, 3 };

            // union of two sets
            Console.WriteLine("\nUnion of two sets");
            set1.UnionWith(set2);
            Console.WriteLine("After Union:" + string.Join(",", set1));

            // Intersection of two Union
            Console.WriteLine("\nIntersection of two Union");
            set1.IntersectWith(new HashSet<int> { 6, 7,});
            Console.WriteLine("After Intersection:" + string.Join (",", set1));
        }
    }
}
