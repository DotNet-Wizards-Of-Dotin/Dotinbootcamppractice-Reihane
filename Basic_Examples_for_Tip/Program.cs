using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basice_Examples_for_Tip
{

    public class Program1Main
    {  
        static void Main(string[] args)
        {
            Console.WriteLine("which method do you want to try ? " +
                              "\n 1.Professional_if \n 2.Array_and_lists \n 3.substring_example");

            int input = Convert.ToInt32(Console.ReadLine());
            if (input == 1)
            {
                Methods.Professional_if();
            }
            else if(input == 2)
            {
                Methods.Array_and_lists();
            }
            else if(input == 3)
            {
                Methods.splitter();
            }
        }
    }
}
