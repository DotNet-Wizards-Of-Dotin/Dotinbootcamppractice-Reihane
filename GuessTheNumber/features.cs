using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    internal static class features
    {
        // Helper Method
        public static void DisplayConfusedNumber(int number)
        {
            char[] digits = number.ToString().ToCharArray();
            Random Confusion = new Random();
            for (int i = digits.Length - 1; i > 0; i--)
            {
                int j = Confusion.Next(0, i);
                char temp = digits[i];
                digits[i] = digits[j];
                digits[j] = temp;
            }

            Console.WriteLine($"Confused version: {new string(digits)}");
        }

        //ads method
        public static void ads_method(int secends)
        {
            for (int i = secends; i > 0; i--)
            {
                Console.WriteLine($"Ad will be displayed in {i} seconds...");
                Thread.Sleep(1000); // Wait for 1 second
                Console.Clear();
            }
            //Two chances are added to the player because of the ad it watched

            // Display a final message after the countdown
            Console.WriteLine("Displaying ad now!");
            Thread.Sleep(2000); // Simulate the ad display with a 2-second delay
            Console.Clear();
        }
    }
}
