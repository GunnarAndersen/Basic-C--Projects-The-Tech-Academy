using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Employee : Person //this makes the employee class inherit from the person class.
    {
        public Employee()
        {
            Id = 1;
        }
        public int Id { get; set; }
    }
}
