using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambdas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> EmployeeList = new List<Employee>();
            List<Employee> JoeList = new List<Employee>();

            EmployeeList.Add(new Employee("Joe", "Gates", 1));
            EmployeeList.Add(new Employee("Tom", "Smith", 2));
            EmployeeList.Add(new Employee("Joe", "Haines", 3));
            EmployeeList.Add(new Employee("Zach", "Duck", 4));
            EmployeeList.Add(new Employee("Karen", "Herman", 5));
            EmployeeList.Add(new Employee("Alex", "Smith", 6));
            EmployeeList.Add(new Employee("Martin", "Yanez", 7));
            EmployeeList.Add(new Employee("Constantin", "Lupulescu", 8));
            EmployeeList.Add(new Employee("Andrew", "Xiao", 9));
            EmployeeList.Add(new Employee("Daquan", "Jones", 10));

            foreach (var Employee in EmployeeList)
                Console.WriteLine("Employee: {0}, {1}, {2},", Employee.firstName, Employee.lastName, Employee.Id);



            //List<string> workerNames = new List<string>()
            //{
            //    "Joe", "Tom", "Joe", "Zach", "Karen", "Alex", "Martin", "Collin", "Andrew", "Daquan"
            //};

            //List<string> surnames = new List<string>()
            //{
            //    "Gates", "Smith", "Haines", "Duck", "Herman", "Smith", "Yanez", "Lupulescu", "Xiao", "Jones"
            //};
            //List<int> Id = new List<int>()
            //{
            //    1, 2, 3, 4, 5, 6, 7, 8, 9, 10
            //};
            int i = 0;

            foreach (var employee in EmployeeList)
            {
                if (employee.firstName == "Joe")
                JoeList.Add(new Employee(employee.firstName, employee.lastName, employee.Id));
            }

            Console.WriteLine("Total number of Joes:" + JoeList.Count);
            Console.WriteLine();


            List<Employee> newList = EmployeeList.Where(x => x.firstName == "Joe").ToList();
            int count = newList.Count;
            Console.WriteLine(count);


            List<Employee> newList2 = EmployeeList.Where(y => y.Id > 5).ToList();

            Console.WriteLine(newList2.Count);

            Console.ReadLine();


        }

    }
}