using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter
{
    class Convertor_class : RUels
    {
        public float Ghirat(float input)
        {
            return (input * 5);
        }

        public float Mesghal(float input)
        {
            return (input /(float)4.7f );        
        }

        public float Sout(float input)
        {
            return (input * 1000f);
        }
    }
}
