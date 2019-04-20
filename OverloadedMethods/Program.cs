using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadedMethods
{
    class Program
    {
        static void Main(string[] args)
        {   
            numbers stuff = new numbers();
            numbers.mathFunction(12);
            numbers.mathFunction(3.14m);
            numbers.mathFunction("5");
            Console.ReadLine();

        }
    }
}
