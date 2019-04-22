using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            IQuittable employee1 = new Employee() { FirstName = "Gunnar", LastName = "Andersen", Id = 1 };
            Employee employee2 = new Employee() { FirstName = "Timothy", LastName = "Tugmutton", Id = 2 };
            employee1.Quit(employee2);
        }
    }
}
