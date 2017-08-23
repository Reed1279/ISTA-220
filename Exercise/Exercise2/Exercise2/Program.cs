using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {          
            Console.WriteLine("Please enter # of test scores to be calculated. ");
            int v = int.Parse(Console.ReadLine());
            if (v >= 1 && v <= 100)
            {

                 
                
                float score, sum = 0, avg = 0; int i;
                for (i = 1; i <= v; i++)
                {
                    Console.WriteLine("Enter #{0} Test Score:  ", i);
                    score = float.Parse(Console.ReadLine());
                    sum = sum + score;
                }


                avg = sum / (i - 1);
                Console.WriteLine("Average of Test Scores: " + avg);
                if (avg >= 90 && avg <= 100)
                    Console.WriteLine("         Overall Grade: A");
                else if (avg >= 80 && avg <= 89)
                    Console.WriteLine("         Overall Grade: B");
                else if (avg >= 70 && avg <= 79)
                    Console.WriteLine("         Overall Grade: C");
                else if (avg >= 60 && avg <= 69)
                    Console.WriteLine("         Overall Grade: D");
                else
                    Console.WriteLine("         Overall Grade: F");
                Console.Read();
            }
        }
    }
}
                //2.2 Exercise 2
                //Create a console application that will accept an arbitrary number test scores(as specied by the user)
                //between 0 and 100, average them, and report a letter grade for the average based on the usual scale.For
                //example, a teacher will input the total number of tests, then input ten test scores and see the average
                //numerical grade and the letter grade.
