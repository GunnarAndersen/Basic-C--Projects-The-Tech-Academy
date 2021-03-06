﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please tell us the weight of your package");
            int PackageWeight = Convert.ToInt32(Console.ReadLine());
            //intro is done

                if (PackageWeight > 50)
                {
                Console.WriteLine("Console too heavy to be shipped via Package Express. Have a good day");
                }
                //better to do Convert.ToInt32(console.readline()); because it saves space
            Console.WriteLine("What is the package width?"); 
            int PackageWidth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is the package height?");
            int PackageHeight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is the package length?");
            int PackageLength = Convert.ToInt32(Console.ReadLine());

            if (PackageWidth + PackageHeight + PackageLength > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
            }
            //using float here because it tolerates sig figs
            //uncertain about how the syntax for math goes on C# but I don't want to muck anything up so I'm just playing it safe
            else
            {
                float Total = ((PackageWidth + PackageLength + PackageHeight) * (PackageWeight) / 100);
                Console.WriteLine("Your total is" + Total +"$");
            }
          
            Console.ReadLine();

        }
    }
}
