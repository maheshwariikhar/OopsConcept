using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    class Shape
    {
        public string color;
        public void DisplayDetails()
        {

            Console.WriteLine("color:" + color);
        }
    }
    class Circle : Shape
    {
        public double Radius;
        public void DisplayCircle()
        {
            Console.WriteLine("Shape: Circle");
            DisplayDetails();
            Console.WriteLine("Radius:" + Radius);
        }
    }
    class Rectangle : Shape
    {
        public double Length;
        public double Width;
        public void DisplayRectangle()
        {
            Console.WriteLine("Shape: Rectangle");
            DisplayDetails();
            Console.WriteLine("Lenth:" + Length);
            Console.WriteLine("Width:" + Width);

        }
    }
    internal class HirarchicalInheritance
    {
        static void Main()
        {

            Circle c1 = new Circle();
            c1.color = "red";
            c1.Radius = 5.8;
            c1.DisplayCircle();
            Console.WriteLine(); //seperator

            Rectangle r1 = new Rectangle();
            r1.color = "Green";
            r1.Length = 15;
            r1.Width = 5;
            r1.DisplayRectangle();


        }
    }
}
