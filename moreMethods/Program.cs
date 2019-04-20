using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moreMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write down an integer");
            int uNum = Convert.ToInt32(Console.ReadLine());
            numbers.mathFunction(uNum);
            int uNum2 = 6;
            numbers.mathFunction(out uNum, out uNum2);
            Console.ReadLine();

        }
    }
}
