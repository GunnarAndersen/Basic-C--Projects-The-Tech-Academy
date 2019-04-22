using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumPractice
{
    class Program
    {
        public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hey, what day of the week is it?");
                DaysOfTheWeek currentDay = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), Console.ReadLine());
                Console.WriteLine(currentDay);
            }
            catch (ArgumentException ex) // figured out that I should use this because when I tried to compile it said "argumentexception"
            {
                Console.WriteLine("Error, please enter an actual day of the week");
                
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
