using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouletteTable
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Random run = new Random();
            var r = new Random();
            string[] color = { "Red", "Black" };
            string bet;
            int attempts = 0;
            int amount;
            int money = 1000;
            while (money != 0)
            {
                Console.WriteLine("Current Chips:$" + money + "          Bets Placed: " + attempts);

                Console.WriteLine("\nWelcome to the Roulette Table, my name is Tyler");
                Console.WriteLine("Please place your bet by choosing a number below:");
                Console.WriteLine("1.Even    2.Odd    3.Low    4.High");
                Console.WriteLine(" 5.Red    6.Black    7.1st Dozen");
                Console.WriteLine("   8.2nd Dozen    9.3rd Dozen");
                bet = (Console.ReadLine());
                //Bet
                bet.ToLower();
                bool check = bet == "1" || bet == "2" || bet == "3" || bet == "4" || bet == "5" || bet == "6" || bet == "7" || bet == "8" || bet == "9";
                if (check == false)
                {
                    Console.WriteLine("That's not a proper bet, please try again.");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                else
                {
                Amount:
                    Console.WriteLine("How much would you like to place on that bet?");
                    amount = Convert.ToInt32(Console.ReadLine());
                    //Amount
                    if (amount > money)
                    {
                        Console.WriteLine("Do you need to see the Teller?  It appears that you do not have enough chips!");
                        Console.WriteLine("Press enter to try again.");
                        Console.ReadKey();
                        goto Amount;
                    }
                    else
                    {
                        money -= amount;
                        int spin = run.Next(0, 37);
                        string runColor = color[r.Next(color.Length)];
                        bool even = spin % 2 == 0;
                        if ((((bet == "1") && (even == true))) || (((bet == "2") && (even == false))) || ((bet == "5") && (runColor == "Red") || (bet == "6") && (runColor == "Black")))
                        {
                            Console.WriteLine("The roulette landed on " + runColor + " " + spin);
                            Console.WriteLine("You won! +$" + amount * 2 + "!");
                            Console.WriteLine("<Press enter to continue>");
                            money += amount * 2;
                            attempts += 1;
                            Console.ReadKey();
                        }
                        else if ((bet == "3") && ((spin > 0) && (spin < 19)))
                        {
                            Console.WriteLine("The roulette landed on " + runColor + " " + spin);
                            Console.WriteLine("You won! +$" + amount * 2 + "!");
                            Console.WriteLine("<Press enter to continue>");
                            money += amount * 2;
                            attempts += 1;
                            Console.ReadKey();
                        }
                        else if ((bet == "4") && ((spin > 18) && (spin < 37)))
                        {
                            Console.WriteLine("The roulette landed on " + runColor + " " + spin);
                            Console.WriteLine("You won! +$" + amount * 2 + "!");
                            Console.WriteLine("<Press enter to continue>");
                            money += amount * 2;
                            attempts += 1;
                            Console.ReadKey();
                        }
                        else if ((bet == "7") && (spin > 0 && spin < 13) || (bet == "8") && (spin > 12 && spin < 25) || (bet == "9") && (spin > 24 && spin < 37))
                        {
                            Console.WriteLine("The roulette landed on " + runColor + " " + spin);
                            Console.WriteLine("You won! +$" + amount * 2 + "!");
                            Console.WriteLine("<Press enter to continue>");
                            money += amount * 3;
                            attempts += 1;
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("The roulette landed on " + runColor + " " + spin);
                            Console.WriteLine("You lost! -$" + amount + "!");
                            Console.WriteLine("<Press enter to continue>");
                            attempts += 1;
                            Console.ReadKey();
                            if (money == 0)
                            {
                                Console.WriteLine("It appears that you are out of money.  You may want to hit the ATM in order to get some more chips from the Teller.");
                                Console.WriteLine("<Press enter to continue>");
                                Console.ReadKey();
                            }
                        }
                    }
                }
                Console.Clear();
            }
        }
    }
}

