using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        public static void Main()
        {
            Employee Sample = new Employee() {FirstName = "Sample", LastName = "Student", Id = 2 };
            Sample.SayName(Sample);
            Console.ReadLine();
        }
    }
}
