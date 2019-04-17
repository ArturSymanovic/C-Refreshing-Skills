using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRefreshment
{
    public class Person
    {
        private DateTime _birthdate;

        public string FirstName;
        public string LastName;
        public int Age;
        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, my name is {1} {2}", to, FirstName, LastName);
        }

        public static Person Parse(string str)
        {
            var person = new Person();
            person.FirstName = str;
            return person;
        }

        public void SetBirthdate(DateTime birthdate)
        {
            _birthdate = birthdate;
        }

        public DateTime GetBirthdate()
        {
            return _birthdate;
        }
    }
}
