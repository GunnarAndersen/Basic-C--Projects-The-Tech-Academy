﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //person 1
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("What is your hourly rate?");
            string DollarsPerHour = Console.ReadLine();
            int HourlyRate = Convert.ToInt32(DollarsPerHour);
            Console.WriteLine("How many hours did you work this week?");
            string WeeklyHours = Console.ReadLine();
            int HoursWorked = Convert.ToInt32(WeeklyHours);

            //person 2
            Console.WriteLine("Person 2");
            Console.WriteLine("What is your hourly rate?");
            string DollarsPerHour2 = Console.ReadLine();
            int HourlyRate2 = Convert.ToInt32(DollarsPerHour2);
            Console.WriteLine("How many hours did you work this week?");
            string WeeklyHours2 = Console.ReadLine();
            int HoursWorked2 = Convert.ToInt32(WeeklyHours2);
            //salaries
            int AnnualSalary1 = (HourlyRate * HoursWorked * 52); //52weeks per year
            Console.WriteLine("Person 1 salary is:");
            Console.WriteLine(AnnualSalary1);

            int AnnualSalary2 = (HourlyRate2 * HoursWorked2 * 52);
            Console.WriteLine("Person 2 salary is:");
            Console.WriteLine(AnnualSalary2);

            Console.WriteLine("Does Person 1 Make More Money than Person 2?");
            bool MakesMore = AnnualSalary1 > AnnualSalary2;
            Console.WriteLine(MakesMore);
            Console.ReadLine();
        }
    }
}
