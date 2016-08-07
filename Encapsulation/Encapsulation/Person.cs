using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Person
    {

        /*
        private DateTime _birthdate;

        public void SetBirthdate(DateTime birthdate)
        {
            _birthdate = birthdate;
        }

        public DateTime GetBirthdate()
        {
            return _birthdate;
        }
        */



        //auto implemented properties
        public string Name { get; set; }
        public string Username { get; set; }
        public DateTime Birthdate { get; private set; }
        //use private for set. so it becomes readonly. cannot be modified. Create constructor to set birthday.


        public Person(DateTime birthdate)
        {
            Birthdate = birthdate;
        }

        
        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days / 365;

                return years;
            }
        }
    }
}
