using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Please enter test scores to be calculated. ");
            float score, sum = 0, avg = 0; int i;
            for (i = 1; i <= 100; i++)
            {

                {

                    Console.WriteLine("Enter #{0} Test Score:  ", i);
                    score = float.Parse(Console.ReadLine());
                    sum = sum + score;
                }


                        bool stop = false;

                        stop = (i >= 1 && i <= 100);
                        if (stop)
                    



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


//2.3 Exercise 3
//Create a console application that will accept a number test scores(as calculated by the number of scores
//actually entered) between 0 and 100, average them, and report a letter grade for the average based on the
//usual scale.For example, a teacher will input any number test scores, then and see the average numerical
//grade and the letter grade.