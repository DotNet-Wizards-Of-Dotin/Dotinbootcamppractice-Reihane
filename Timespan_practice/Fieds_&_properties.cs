using System;

namespace MyNamespace
{
    internal class Person
    {
        //fields
        private int _id;
        private string _fullname;
        private DateTime _birthdate;
        private TimeSpan _age; 

        //properties
        public int ID { get { return _id; } set { _id = value; } }
        public string Fullname { get { return _fullname; } set { _fullname = value; } }
        public DateTime Birthdate { get { return _birthdate; } set { _birthdate = value; } }

        public double Age
        {
            get
            {
                TimeSpan Calcuteage =DateTime.Now - _birthdate;
                double _age=Calcuteage.TotalDays /365.25 ;
                return Math.Round(_age,2);
            }
        }
    }
}
