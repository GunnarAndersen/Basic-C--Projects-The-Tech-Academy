using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twoParamMethod
{
    public class nums
    {
        public nums()
        {
            worth = 7;
        }
        public int worth { get; set; }

        public static void exercise(int n, int m)
        {
            
            int one = n;
            int two = m;
            int newOne = one + 5;
            Console.WriteLine("is "+ two+" your second number?");
            Console.ReadLine();

        }
    }
}
