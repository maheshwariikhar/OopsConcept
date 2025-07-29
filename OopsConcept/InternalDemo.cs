using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    internal class InternalDemo
    {
        internal void ShowInternalMessage()
        {
            Console.WriteLine("This is an Internal method");
        }
        static void Main()
        {
            InternalDemo obj = new InternalDemo();
            obj.ShowInternalMessage();

        }
    }
    }

