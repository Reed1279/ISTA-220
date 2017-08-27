using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFarm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, and welcome to the Farm.  Please hit 'ENTER' to meat our fun little friends");
            Console.ReadLine();

            Cat p1 = new Cat();
            Console.WriteLine("Hello, I am a Cat");
            p1.name();
            p1.eat();
            p1.sound();
            p1.like();
            Console.WriteLine("Would you like to meet my friend the Cow? Press 'ENTER'");
            Console.ReadLine();
            
            Cow c1 = new Cow();
            Console.WriteLine("Hi, I am a Cow");
            c1.name();
            c1.eat();
            c1.sound();
            c1.like();
            Console.WriteLine("I have a furry little friend named Dog, would you like to meet him? Press 'ENTER'");
            Console.ReadLine();

            Dog d1 = new Dog();
            Console.WriteLine("Well Hello, I am a Dog");
            d1.name();
            d1.eat();
            d1.sound();
            d1.like();
            Console.WriteLine("I would like to take you to meet the stinky one here at the farm.  "+
                "I call her Fat Amy, but the farmer always call's her his ex-wife.  Would you like to meet her? Press 'ENTER'");
            Console.ReadLine();

            Pig a1 = new Pig();
            Console.WriteLine("Oink, I am a Pig Oink");
            a1.name();
            a1.eat();
            a1.sound();
            a1.like();
            Console.WriteLine("I would take you to a friend to meet, but no one likes me becuase I am a stinky fat pig.  "+
                "If you want to leave though, just press 'ENTER'");
            Console.ReadLine();

            Console.WriteLine("Thank you for visiting, hope you come again.");
            Console.ReadLine();

           
        }
    }
}
