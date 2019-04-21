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
        
    }
}
