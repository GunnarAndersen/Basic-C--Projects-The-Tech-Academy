using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Employee : Person, IQuittable
    {
         //this makes the employee class inherit from the person class.
        
            public List<Employee> Employees { get; set; }
            public Employee()
            {
                Id = 1;
            }
            public int Id { get; set; }

            public void Quit(Employee employee)
        {
            Console.WriteLine("I have HAD IT WITH THIS JOB! I'M DONE!");
            Console.ReadLine();
        }

        public static bool operator ==(Employee employee1, Employee employee2)
        {
            if (employee1.Id == employee2.Id)
                return true;
            else
                return false;
        }

        public static bool operator !=(Employee employee1, Employee employee2)
        {
            if (employee1.Id != employee2.Id)
                return true;
            else
                return false;
        }
        public override int GetHashCode()
        {
            return this.Id.GetHashCode(); 
        }


    }
}
