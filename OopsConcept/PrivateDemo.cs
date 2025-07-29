using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    internal class PrivateDemo
    {
        private static object obj;

        public void ShowSecret()
        {
            Console.WriteLine("This is a Secret Method");

        }
        public void AccessPrivateMethod()
        {
            //call private method
            ShowSecret();

        }
        static void Main()
        {
            PrivateDemo demo = new PrivateDemo();
            demo.AccessPrivateMethod();
            //InternalDemo demo = new PrivateDemo();
            //demo.AccessPrivateMethod();


        }

    }
}
