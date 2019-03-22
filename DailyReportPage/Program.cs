using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechAcademyDrill2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("What Course are you on?");
            string Course = Console.ReadLine();
            Console.WriteLine("What Page Number are you on?");
            string PageNo = Console.ReadLine();
            int page = Convert.ToInt32(PageNo);
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\"");
            string trueOrFalse = Console.ReadLine();
            bool tOf = Convert.ToBoolean(trueOrFalse);
            Console.WriteLine("Were there any positive experiences you'd like to share? Please provide specifics");
            string PositiveExperiences = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string hoursStudied = Console.ReadLine();
            int studyTime = Convert.ToInt32(hoursStudied);
            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
                
        }
    }
}
