using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twoParamMethod
{
    class Program
    {
        public static void Main(string[] args)
        {
            nums uNum = new nums();
            Console.WriteLine("Hi, please pick a number");
            int choice1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Okay now I need another number");
            int choice2 = Convert.ToInt32(Console.ReadLine());
            nums.exercise(choice1, choice2);
        }

     
    }
}
