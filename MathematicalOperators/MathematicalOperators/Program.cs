using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechAcademyDrill3
{
    class Program
    {
        static void Main(string[] args)
        {
            //initial multiplication
            Console.WriteLine("Put in a number");
            string input = Console.ReadLine();
            int Number1 = Convert.ToInt32(input);

            int Number2 = Number1 * 50;
            Console.WriteLine(Number2);

            //add
            Console.WriteLine("Put in another number");
            string input2 = Console.ReadLine();
            int AddNumber = Convert.ToInt32(input2);

            int AddNumber2 = AddNumber + 25;
            Console.WriteLine(AddNumber2);
            
            //division
            Console.WriteLine("Put in another number");
            string input3 = Console.ReadLine();
            int DivNumber = Convert.ToInt32(input3);
            float FloatyDiv = DivNumber;

            float DivNumber2 = FloatyDiv / 12.5f;
            Console.WriteLine(DivNumber2);

            //next function

            Console.WriteLine("Put in another number");
            string input4 = Console.ReadLine();
            int boolNumber = Convert.ToInt32(input4);
            bool big = boolNumber > 50;
            Console.WriteLine(big);

            //last function

            Console.WriteLine("Put in another number");
            string input5 = Console.ReadLine();
            int ModNumber = Convert.ToInt32(input5);
            float Modulo = ModNumber;

            Console.WriteLine(Modulo % 7);
            Console.ReadLine();

        }
    }
}
