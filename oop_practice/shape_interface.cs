using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_practice
{
    public interface Ishape
    {
        int ID { get; set; }
        double CalcuteArea();
        double  CalculatePerimeter();
    }

    public interface IDescription
    {
        string GetDescription ();
    }
    internal class Regtangle2 : Ishape ,IDescription
    {
        public int ID {  get; set; }

        public double lenght { get; set; }
        public double width { get; set; }
        public double area { get; set; }
        public double perimeter { get; set; }
        public double CalculatePerimeter()
        {
            perimeter = (lenght + width) * 2;
            return perimeter;
        }

        public double CalcuteArea()
        {
            area = lenght * width;
            return area;
        }

        public string GetDescription()
        {
            CalculatePerimeter();
            CalcuteArea();
            string result1 = $"CalcuteArea[interface]  ID:{ID}  = {area} , Calcuteperimeter[interface] = {perimeter}  ";
            return result1; 
        }
    }
    internal class Circle2 : Ishape, IDescription
    {
        public int ID { get; set; }
        public double Radius {  get; set; }
        public double area { get; set; }
        public double perimeter { get; set; }
        public double CalculatePerimeter()
        {
            perimeter = Radius * 3.14;
            return perimeter;
        }

        public double CalcuteArea()
        {
            area = Radius * Radius * 3.14;
            return area;
        }

        public string GetDescription()
        {
            CalculatePerimeter();
            CalcuteArea();
            string result2 = $"CalcuteArea[interface]  ID:{ID}  = {area} , Calcuteperimeter[interface] = {perimeter}  ";
            return result2;
        }
    }

}