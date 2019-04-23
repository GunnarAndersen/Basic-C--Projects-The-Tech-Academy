using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datetime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentYear = DateTime.Now;
            Console.WriteLine(currentYear);
            Console.WriteLine("Hi, please give me a number to look at.");
            int x = Convert.ToInt32(Console.ReadLine());
            DateTime futureTime = currentYear.AddHours(x);
            Console.WriteLine("In " + x + " hours it will be...");
            Console.WriteLine(futureTime);
            Console.ReadLine();
        }
    }
}
