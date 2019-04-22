using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Person
    {
        public Person()
        {
            FirstName = "Gunnar";
            LastName = "Andersen";
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void SayName()
        {
            Console.WriteLine("Name:" + FirstName + " " + LastName);
        }
    }
}
