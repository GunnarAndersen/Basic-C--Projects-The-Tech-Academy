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
            Employee employee1 = new Employee() { Id = 1, FirstName = "Gunnar", LastName = "Andersen" };
            Employee employee2 = new Employee() { Id = 2, FirstName = "Katie", LastName = "Wise" };
            Employee employee3 = new Employee() { Id = 3, FirstName = "Andrew", LastName = "Smith" };
            Employee employee4 = new Employee() { Id = 1, FirstName = "Lionel", LastName = "Busque" };
            if (employee1 == employee2)
                Console.WriteLine("equal");
            else Console.WriteLine("not equal");

            if (employee2 == employee2)
                Console.WriteLine("equal");
            else Console.WriteLine("not equal");

            if (employee1 == employee4)
                Console.WriteLine("equal");
            else Console.WriteLine("not equal");

            Console.ReadLine();
        }
    }
}
