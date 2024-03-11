using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_practice
{
    internal class shape_poly
    {
        //parent
        public int ID {  get; set; }

        public virtual string CalculatePerimeter()
        {
            return $"CalculatePerimeter[poly]  ";
        }
        public virtual string CalcuteArea()
        {
            return $"CalcuteArea[poly]  ";
        }

    }
    internal class Regtangle : shape_poly
    {
        public float lenght { get; set; }
        public float width {  get; set; }
        public override string CalculatePerimeter()
        {
            var CalculatePerimeter = base.CalculatePerimeter();
            CalculatePerimeter += $"ID:{ID} = {(lenght + width)*2}";
            return CalculatePerimeter ;
        }
        public override string CalcuteArea()
        {
            var CalcuteArea = base.CalcuteArea();
            CalcuteArea += $"ID:{ID} = {lenght * width }";
            return CalcuteArea;
        }

    }
    internal class circle : shape_poly
    {
        public float radius { get; set; }
        public override string CalculatePerimeter()
        {
            var CalculatePerimeter = base.CalculatePerimeter();
            CalculatePerimeter += $"ID:{ID} = {radius*3.14}";
            return CalculatePerimeter ;
        }
        public override string CalcuteArea()
        {
            var CalcuteArea = base.CalcuteArea();
            CalcuteArea += $"ID:{ID} = {radius*radius * 3.14}";
            return CalcuteArea ;
        }
     


    }

}
