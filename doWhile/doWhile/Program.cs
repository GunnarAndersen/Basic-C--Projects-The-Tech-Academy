using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("If you give me a number smaller than 100, I will give you EVERY integer that is smaller than 100 and larger than your number.");
            int number = Convert.ToInt32(Console.ReadLine()); 
            
            switch (number)
            {
                case 100:
                    Console.WriteLine("Too big, try again");
                    break;
               
            }
            do
            {
                Console.WriteLine(number);
                number++;
            }
            while (number < 100);
          
            Console.ReadLine();
        }

        

        }
}
