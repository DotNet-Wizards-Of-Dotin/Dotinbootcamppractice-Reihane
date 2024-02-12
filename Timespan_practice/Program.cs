using System;

namespace MyNamespace // Same unique namespace name as in the class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person1 = new Person()
            {
                ID = 1,
                Fullname = "Rih sha",
                Birthdate = new DateTime(2001, 07, 05),
            };
            Console.WriteLine(person1.Age);
        }
    }
}