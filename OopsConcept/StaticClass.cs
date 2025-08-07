using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    static class CatWorld
    {
        public static int NumberOfCats;
        public static int TotalCatNaps;

        static CatWorld()
        {
            NumberOfCats = 5;
            TotalCatNaps = 3;
        }
        public static void AddCats()
        {
            NumberOfCats++;
            Console.WriteLine($"A New Cat Has Joined:{NumberOfCats}");
        }
        public static void AddNap()
        {
            TotalCatNaps++;
            Console.WriteLine($"Total Number of Cat Naps:{TotalCatNaps}");
        }
    }
    internal class StaticClass
    {
        static void Main()
        {
            CatWorld.AddCats();
            CatWorld.AddNap();

        }
    }
}
