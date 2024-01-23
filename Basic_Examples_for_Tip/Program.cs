using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RihTools.Extension;


namespace Basice_Examples_for_Tip
{

    public class Program1Main
    {  
        static void Main(string[] args)
        {
            Console.Clear();
            while (true)
            {
                Console.WriteLine("which method do you want to try ? " +
                                  "\n 1.Professional_if \n 2.Array_and_lists \n 3.substring_example");
                var input = Console.ReadLine();

                if (input.IsNullOrEmptyOrZero())
                {
                    Console.WriteLine("String is null, empty, or zero.");
                    Methods.StartAgain();
                }
                else
                {
                    //convert input to an integer
                    if (int.TryParse(input, out int int_input))
                    {

                        if (int_input == 1)
                        {
                            Methods.Professional_if();
                        }
                        else if (int_input == 2)
                        {
                            Methods.Array_and_lists();
                        }
                        else if (int_input == 3)
                        {
                            Methods.splitter();
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a valid number.");
                            Methods.StartAgain();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                        Methods.StartAgain();
                    }
                }
            }


        }
    }
}
