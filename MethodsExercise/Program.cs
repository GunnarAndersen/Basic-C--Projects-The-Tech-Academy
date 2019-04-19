using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Numbers uNum = new Numbers();
            Console.WriteLine("Write down a number. I am going to some experiments on it, but it won't die so don't worry.");
            uNum.Value = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(uNum.Value);
            Numbers.addTwoInts(uNum.Value); //takes an int argument so I put in uNum.Value which is an int
            Numbers.subTwoInts(uNum.Value);
            Numbers.multTwoInts(uNum.Value);
            Console.ReadLine();
        }
    }
}
