using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRefreshment
{
    public class Person
    {
        
        public DateTime Birtdate { get; private set; }
        public string Name { get; set; }
        public string Username { get; set; }

        public Person(DateTime birthdate)
        {
            Birtdate = birthdate;
        }

        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - Birtdate;
                return timeSpan.Days / 365;
            }
        }
    }
}
