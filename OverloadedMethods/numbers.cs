using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadedMethods
{
    class numbers
    {
        public numbers()
        {
            Value = 7;
        }
        public int Value { get; set; }

        public static int mathFunction(int n) //Was having issues. I needed to make this so that it is a static int
        {
            Console.WriteLine("Adding Numbers...");
            int result = n + 2;
            Console.WriteLine(result);
            return result;
        }

        public static int mathFunction(decimal n) //second version of this
        {
            Console.WriteLine("Modulo!");
            int result = Convert.ToInt32(n % 2);
            Console.WriteLine(result);
            return result;
        }

        public static int mathFunction(string n) //s version of this
        {
            Console.WriteLine("Whoa there! let's make that string into an integer if possible....");
            int integer = Convert.ToInt32(n);
            Console.WriteLine("Let's make it bigger!");
            int result = integer * 6;
            Console.WriteLine(result);
            return result;
        }
    }
}
