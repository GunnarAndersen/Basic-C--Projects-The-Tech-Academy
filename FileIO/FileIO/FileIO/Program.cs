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
            
            string txtContents = System.IO.File.ReadAllText(@"C:\nums\nums.txt");

            // Display the file contents to the console. Variable text is a string.
            System.Console.WriteLine("Contents of your text file = {0}", txtContents);
            Console.ReadLine();
        }
    }
}
