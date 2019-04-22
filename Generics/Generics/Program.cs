using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employeeNames = new Employee<string>() {Things = new List<string>() { "Bob", "Tom", "Ralph", "Stephen", "Stanley" } };
            Employee<int> employeeId = new Employee<int>() { Things = new List<int>() { 1, 2, 3, 4, 5 } };

            //these lists need to be put in this fashion or else it will give a conversion error. 

            foreach (string employee in employeeNames.Things)
                {
                Console.WriteLine(employee);
                }
            //we print "employee" because if we do not it will not cycle through the object list and give us the names.
          
            foreach (int Id in employeeId.Things)
            {
                Console.WriteLine(Id);
            }
            Console.ReadLine();
            

        }
    }

}
