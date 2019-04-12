using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] names = new string[4];

            names[0] = "Yes";
            names[1] = "Noworries";
            names[2] = "Time";
            names[3] = "Tired";

            Console.WriteLine("Enter a string!");

            string uString = Console.ReadLine();

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i] + uString);
                Console.ReadLine();
            }
            //step 1 complete, bit of a weird instruction

            Console.WriteLine("Enter a number");




            int j = Convert.ToInt32(Console.ReadLine());

            switch (j)
            {
                case 100:
                    Console.WriteLine("Yeah");
                    break;

            }
            do
            {
                Console.WriteLine(j);
                j++;
                break;
            }
            while (j < 100); //without this loop will be infinite, when I have j < 100 this is true so it will be a loop
            {

            }

            Console.WriteLine("Okay now do something else");

            // do
            {
                Console.WriteLine(j);
                j++;
            }

            while (j >= 50) 
            {
                Console.WriteLine("This appears to be true");
            }

            Console.WriteLine("Type in a string and we will match it to its index. Strings include the words yes, no, maybe, sometimes and absolutely");

            List<string> strList = new List<string> { "yes", "no", "maybe", "sometimes", "absolutely" };

            String caseSwitch = Console.ReadLine();

            switch (caseSwitch)
            {
                case "yes":
                    Console.WriteLine(strList[0]);
                    Console.WriteLine("Location 0");
                    Console.ReadLine();
                    break;
                case "no":
                    Console.WriteLine(strList[1]);
                    Console.ReadLine();
                    Console.WriteLine("Location 1");
                    break;
                case "maybe":
                    Console.WriteLine(strList[2]);
                    Console.WriteLine("Location 2");
                    Console.ReadLine();
                    break;
                case "sometimes":
                    Console.WriteLine(strList[3]);
                    Console.WriteLine("Location 3");
                    Console.ReadLine();
                    break;
                case "absolutely":
                    Console.WriteLine(strList[4]);
                    Console.WriteLine("Location 4");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Not on the list! Try again");
                    Console.ReadLine();
                    break;
            }

            List<string> strList2 = new List<string> { "Yes", "Yes", "Early", "Often", "Always" };
            string Switch2 = Console.ReadLine();

            Console.WriteLine("Enter a string that is on my list. You can enter yes, early, often, or always");

            switch (Switch2)
            {
                case "Yes":
                    Console.WriteLine(strList[0]);
                    Console.WriteLine("Location 0");
                    Console.WriteLine("Location 1");
                    Console.ReadLine();
                    break;
                case "Early":
                    Console.WriteLine(strList[2]);
                    Console.WriteLine("Location 2");
                    Console.ReadLine();
                    break;
                case "Often":
                    Console.WriteLine(strList[3]);
                    Console.WriteLine("Location 3");
                    Console.ReadLine();
                    break;
                case "Always":
                    Console.WriteLine(strList[4]);
                    Console.WriteLine("Location 4");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Not on the list! Try again");
                    Console.ReadLine();
                    break;
            }
            List<string> strList3 = new List<string> { "Yes", "Yes", "Thank", "You", "Next" };

            Console.WriteLine("Type in a string");
            //retrieving value using foreach loop
            int z = 0;
            foreach (string thing in strList3)
            {
                Console.WriteLine(thing);
                if (strList3.IndexOf(thing) < z)
                    Console.WriteLine("I have already written this string");
                z++;
                Console.ReadLine();
            }

        }


    }
}