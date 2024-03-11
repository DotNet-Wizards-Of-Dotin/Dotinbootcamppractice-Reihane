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

            var absTest = new shape_abstract[]
            {
                    new Regtangle1
                    {
                        ID=1,
                        lenght = 5,
                        width=2,

                    },
                    new circle1
                    {
                        ID=2,
                        radius = 2,

                    },
                    new Regtangle1
                    {

                        ID = 3,
                        lenght = 3,
                        width=4,

                    },

            };
            foreach (var item in absTest)
            {
                Console.WriteLine(item.CalcuteArea());
                Console.WriteLine(item.CalculatePerimeter() + $"\n");

            }
            var polytest = new List<shape_poly>
            {
                    new Regtangle
                    {
                        ID=1,
                        lenght = 50,
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
            foreach (var item in polytest)
            {
                Console.WriteLine(item.CalcuteArea());
                Console.WriteLine(item.CalculatePerimeter() + $"\n");

            }
            List<Ishape> interfaceTest = new List<Ishape>();

            interfaceTest.Add(new Regtangle2() { ID = 1, lenght = 3, width = 4 });
            interfaceTest.Add(new Circle2() { ID = 2, Radius = 2 });


            //foreach for intefac result
            foreach (var item in interfaceTest)
            {
                if (item is IDescription description)
                {
                    Console.WriteLine(description.GetDescription());
                }

            }
        }
    }
}
