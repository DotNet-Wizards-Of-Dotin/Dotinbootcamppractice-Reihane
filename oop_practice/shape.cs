using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_practice
{
    internal class shape
    {
        //parent
        public int ID {  get; set; }
        //public virtual string printID()
        //{

        //    return $"ID={ID}";
        //}
        public virtual string CalculatePerimeter()
        {
            return $"CalculatePerimeter = ";
        }
        public virtual string CalcuteArea()
        {
            return $"CalcuteArea = ";
        }

    }
    internal class Regtangle : shape
    {
        public float lenght { get; set; }
        public float width {  get; set; }
        public override string CalculatePerimeter()
        {
            var CalculatePerimeter = base.CalculatePerimeter();
            CalculatePerimeter = $"CalculatePerimeter ID:{ID} = {(lenght * width)*2}";
            return CalculatePerimeter ;
        }
        public override string CalcuteArea()
        {
            var CalcuteArea = base.CalcuteArea();
            CalcuteArea = $"CalculatePerimeter ID:{ID} = {lenght * width * 3.14}";
            return CalcuteArea;
        }

    }
    internal class circle : shape
    {
        public float radius { get; set; }
        public override string CalculatePerimeter()
        {
            var CalculatePerimeter = base.CalculatePerimeter();
            CalculatePerimeter = $"CalculatePerimeter ID:{ID} = {radius*3.14}";
            return CalculatePerimeter ;
        }
        public override string CalcuteArea()
        {
            var CalcuteArea = base.CalcuteArea();
            CalcuteArea = $"CalculatePerimeter ID:{ID} = {radius*radius * 3.14}";
            return CalcuteArea ;
        }
     


    }

}
