﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsurance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            string Uage = Console.ReadLine();
            int age = Convert.ToInt32(Uage);
            //DUI, true or false you don't sort of have a DUI

            Console.WriteLine("Have you ever had a DUI? Answer with 'True' or 'False' ");
            string uDUI = Console.ReadLine();
            bool DUI = Convert.ToBoolean(uDUI);

            //Speeding tickets

            Console.WriteLine("How many speeding tickets do you have?");
            string uTickets = Console.ReadLine();
            int Tickets = Convert.ToInt32(uTickets);
            //end questions

            //Needs to be 16, no DUIs, 3 speeding tickets max but fewer preferred
            Console.WriteLine("One second. Determining if you are qualified...");
            bool oldEnough = age > 15;
            bool soberEnough = DUI == false;
            bool slowEnough = Tickets <= 3;
            bool Qualified = oldEnough && slowEnough && soberEnough; 
            Console.WriteLine(Qualified);
            Console.ReadLine();
        }
    }
}
