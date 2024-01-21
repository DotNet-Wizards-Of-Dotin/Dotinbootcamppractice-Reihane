using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_avarage_from_CSV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string csvData = System.IO.File.ReadAllText("personInformation.csv");
            //split the code by each new line
            var PersonData = csvData.Split('\n').Skip(1);
            //create a list to convert csv to list
            //the type of list , should be the type of our class!!
            List<PersonInformation> Person_list = new List<PersonInformation>();
            //splititng each information of one person
            foreach (var person in PersonData)
            {
                var details = person.Split(',');

                // making an object for each person
                PersonInformation each_person = new PersonInformation
                {

                    FirstName = details[0],
                    LastName = details[1],
                    Gender = details[2],
                    Age = int.Parse(details[3]),
                    City = details[4]
                };
                Person_list.Add(each_person);
            }
            double averageAgeMen = Person_list.Where(p => p.Gender == "male").Average(p => p.Age);
            double averageAgeWomen = Person_list.Where(p => p.Gender == "female").Average(p => p.Age);

            Console.WriteLine($"Average age of men: {averageAgeMen}");
            Console.WriteLine($"Average age of women: {averageAgeWomen}");
           

        }

    }
}
