using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_and_Circumference_of_a_Circle
{
    class Program
    {
        static void Main(string[] args)
        { //Program to find the area and circumference of a circle
            double radius;
            double PI = 3.142;
            double area, circle, diameter;
            Console.Write("Enter the Radius of a Circle ");
            radius = double.Parse(Console.ReadLine());
            area = PI * (radius * radius);
            circle = 2 * PI * radius;
            diameter = 2 * PI;
            Console.WriteLine("The area of a Circle is " + area);
            Console.WriteLine("The Circumference of a Circle is " + circle);
            Console.WriteLine("The Diameter of a Circle is " + diameter);
            Console.ReadLine();

        }
    }
}
