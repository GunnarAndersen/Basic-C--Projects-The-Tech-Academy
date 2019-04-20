using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParams
{
    class Program
    {
        public static void Main(string[] args)
        {
            numbers leest = new numbers();
            Console.WriteLine("Please give me one number at a time.The second is optional");
            int hang = Convert.ToInt32(Console.ReadLine());
            numbers.mathFunction(hang);
            
        }
    }
}
