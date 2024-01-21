using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_avarage_from_CSV
{
    public class PersonInformation
    {
        //i made a class to manage the rows of information for each person better
        //each rows gonna be a object of this class


        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
    }
    //method for calcute the avarahe the womwn and man ages
}
