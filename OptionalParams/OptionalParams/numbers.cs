using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParams
{
    class numbers
    {
        public static void mathFunction(int req, int opt = 0) //need to have an optional parameter
        { 
            try
            {
                
                Console.WriteLine("Another, please... but you don't have to. It is optional after all");
                opt = Convert.ToInt32(Console.ReadLine());
                int result = req + 5 + opt;
                Console.WriteLine(result);
                
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Sorry, we're just going with the default now.");
                opt = 0;
                Console.WriteLine(req + 5 + opt);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
