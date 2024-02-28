using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            var shapes = new List<shape>
            {
                new Regtangle
                {
                    ID=1,
                    lenght = 5,
                    width=2,

                },
                new circle
                {
                    ID=2,
                    radius = 2,

                },
                new Regtangle
                {

                    ID = 3,
                    lenght = 3,
                    width=4,

                },

            };
            foreach (var item in shapes)
            {
                Console.WriteLine(item.CalcuteArea());
                Console.WriteLine(item.CalculatePerimeter() +$"\n");
                
            }
        }
    }
}
