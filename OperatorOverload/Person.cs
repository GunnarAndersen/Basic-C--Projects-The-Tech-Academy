using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Person
    {
        public Person()
        {
            FirstName = "Gunnar";
            LastName = "Andersen";
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void SayName(Employee sample)
        {
            Console.WriteLine("Name:" + FirstName + " " + LastName);
        }
    }
}
