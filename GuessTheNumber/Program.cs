using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace GuessTheNumber
{
    //simple version for a bginner proggrammer
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Choose The game mode(1,2,3) :1.Simple   2.Medium   3.Hard");
            int GameMode = int.Parse(Console.ReadLine());

            //Initialize the Range due to mode

            Random random = new Random();
            int max = GameMode == 1 ? 100 : GameMode == 2 ? 200 : GameMode == 3 ? int.MaxValue : 0;
            int randomNumber = random.Next(1, max);
            Console.WriteLine($"The selected number is between 0 and {max}");

            //number of try due to the mode

            int lasttry = GameMode == 1 ? int.MaxValue : GameMode == 2 ? 10 : GameMode == 3 ? 10 : 0;

            //the main part of game start here:
            int chance = lasttry - 1;
            for (int numberoftry = 1; numberoftry <= lasttry; numberoftry++)
            {
                //See Ads to get more chances
                if (numberoftry == lasttry - 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("This is your last chance. Do you want to watch ads to get more chances? (y/n)");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    string input_ads = Console.ReadLine();
                    if (input_ads.ToLower() == "y")
                    {
                        features.ads_method(10);
                        numberoftry -= 2;
                        chance += 2;
                    }
                }

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"please pckup your {numberoftry}th try ,{chance--}chance left!");
                Console.ForegroundColor = ConsoleColor.Gray;
                int input = int.Parse(Console.ReadLine());

                if (numberoftry == lasttry && input != randomNumber)
                {
                    Console.WriteLine("Game over ! ");
                    break;
                }

                //Help
                else if (numberoftry == lasttry / 2)
                {
                    Console.WriteLine("need Help? y/n (you will lost 2 chance)");
                    string input_help = Console.ReadLine();
                    if (input_help.ToLower() == "y")
                    {
                        features.DisplayConfusedNumber(randomNumber);
                        numberoftry += 2;
                        chance -= 2;
                    }

                }
                else if (input < randomNumber)
                {
                    Console.WriteLine("Grathear!");
                }
                else if (input > randomNumber)
                {
                    Console.WriteLine("shorter");
                }
                else
                {
                    Console.WriteLine("Thats right!");
                    break;
                }


            }


        }
    }
}


