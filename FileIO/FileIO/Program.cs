using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi, please give me a number.");
            int uNum = int.Parse(Console.ReadLine());
            string rlyANum = Convert.ToString(uNum);
            File.WriteAllText(@"C:\nums\nums.txt", rlyANum);

            Console.WriteLine(rlyANum);
            Console.ReadLine();
        }
    }
}
