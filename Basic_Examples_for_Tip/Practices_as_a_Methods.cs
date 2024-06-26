﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Basice_Examples_for_Tip
{
    public static class Methods
    {
        public static void Professional_if()
        {
            Console.WriteLine("enter a number : ");
            int Givennumer = Convert.ToInt32(Console.ReadLine());
            string sign = (Givennumer >= 0 ? "positive" : "negative");
            string Result = ((Givennumer % 2 == 0) ? "even" : "odd");
            Console.WriteLine(sign + " " + Result);
        }
        public static void Array_and_lists()
        {
            //Write an array that have contain just even number
            Console.WriteLine("enter 10 number, i will seprate evens and odds");
            int[] array = new int[10];
            for (int i = 0; i < 10; i++)
            {
                int j = i + 1;
                Console.WriteLine($"enter number {j}th : ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            //note!!! we dont know each time how many of the are even or odd
            //but we cant have dynamic array , so we should use lists!
            List<int> evenlist = new List<int>();
            List<int> oddlist = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    evenlist.Add(array[i]);
                }
                else
                {
                    oddlist.Add(array[i]);
                }
            }
            foreach (int k in evenlist)
            {
                Console.WriteLine("the even list is");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(k);
            }
            foreach (int k in oddlist)
            {
                Console.WriteLine("the odd list is");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(k);
            }
        }
        public static void splitter()
        {
            Console.WriteLine("enter your fullname");
            var Fullname = Console.ReadLine();
            // which index have ' '(space)?
            //page 178 nutshell +page 10 nutshell
            int spaceIndex = Fullname.IndexOf(' ');

            if (spaceIndex != -1)
            {
                string firstName = Fullname.Substring(0, spaceIndex);
                string lastName = Fullname.Substring(spaceIndex + 1);

                Console.WriteLine($"your firstname is {firstName} and your lastname is {lastName}");
            }
            else
            {
                Console.WriteLine("please use space for splitting your first &lastname");
            }

        }
        public static void StartAgain()
        {
            Console.WriteLine("Restarting in 3 seconds...");
            Thread.Sleep(3000);
            Console.Clear(); 
        }
    }
}

