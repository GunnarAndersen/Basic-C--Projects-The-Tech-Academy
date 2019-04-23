using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambdas
{
    public class Employee
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int Id { get; set; }
        public Employee(string _firstName, string _lastName, int _ID)
        {
            firstName = _firstName;
            lastName = _lastName;
            Id = _ID;
        }
    }
}
