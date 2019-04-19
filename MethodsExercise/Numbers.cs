using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsExercise
{
    public class Numbers
    {
        public Numbers()
        {
            Value = 7;
        }
        public int Value { get; set; }

        public static int addTwoInts(int n) //Was having issues. I needed to make this so that it is a static int
        {
            Console.WriteLine("Adding Numbers...");
            int result = n + 2;
            Console.WriteLine(result);
            return result;
        }

        public static int subTwoInts(int n)
        {
            Console.WriteLine("Subtracting Numbers...");
            int result = n - 2;
            Console.WriteLine(result);
            return result;
        }
        public static int multTwoInts(int n)
        {
            Console.WriteLine("Multiplying Numbers...");
            int result = n * 2;
            Console.WriteLine(result);
            return result;
        }
    }
        
       
}
    

