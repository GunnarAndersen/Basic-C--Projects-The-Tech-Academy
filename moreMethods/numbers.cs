using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moreMethods
{
    static class numbers
    {
        
        public static void mathFunction(int m)
        {
            Console.WriteLine("dividing your number...");
            Console.WriteLine(m / 2);
        }
        public static void mathFunction(out int x, out int y)
        {
            Console.WriteLine("Hi, please give me a new integer");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(x);
            Console.WriteLine("Now adding your integer");
            y = x + 2;
            Console.WriteLine(y);

        
    }   }
}
