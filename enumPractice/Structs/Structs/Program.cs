using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            Number Price = new Number();
            Price.Amount = 3.14m;
            Console.WriteLine(Price.Amount);
            Console.ReadLine();
        }
    }
}
