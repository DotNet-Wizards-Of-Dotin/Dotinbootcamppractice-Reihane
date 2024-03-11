using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace oop_practice
{
    internal abstract class shape_abstract
    {
        //property
        public abstract int ID { get; set; }

        public abstract string CalcuteArea();
        public abstract string CalculatePerimeter();
    }

    internal class Regtangle1 : shape_abstract
    {
        public override int ID { get; set; }

        public float lenght { get; set; }
        public float width { get; set; }
        public override string CalcuteArea ()
        {
            string CalcuteArea = $"CalcuteArea[abs]  ID:{ID}  = {lenght * width}";
            return CalcuteArea;
            
        }

        public override string CalculatePerimeter()
    {
            string CalculatePerimeter = $"CalcutePerimeter[abs]  ID:{ID}  =  {(lenght+ width )*2}";
            return CalculatePerimeter;
    }

}
    internal class circle1 : shape_abstract
    {
        public override int ID { get; set; }


        public float radius { get; set; }
        public float width { get; set; }
        public override string CalcuteArea()
        {
            string CalcuteArea = $" CalcuteArea[abs] ID:{ID}  =  {radius * radius * 3.14}"; ;
            return CalcuteArea;

        }

        public override string CalculatePerimeter()
        {
            string CalculatePerimeter = $"Calcuteperimeter[abs] ID:{ID}  =  {radius * 3.14}"; ;
            return CalculatePerimeter;
        }

    }




}
