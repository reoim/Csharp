using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(new DateTime(1986, 2, 2));

            //person.SetBirthdate(new DateTime(1986, 2, 2));
            //Console.WriteLine(person.GetBirthdate()); 

            //person.Birthdate = new DateTime(1986, 2, 2);
            Console.WriteLine(person.Age);
        }
    }
}
