using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfaTriangle1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculate the area of a triangle and dive the length of the sides A, B, and C.");
            int a, b, c;
            double area, p;
            Console.WriteLine("Enter the length of saide A: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the length of saide B: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the length of saide C: ");
            c = Convert.ToInt32(Console.ReadLine());
            p = (a + b + c) / 2;
            area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine("The area is " + area);
        }
    }
}
