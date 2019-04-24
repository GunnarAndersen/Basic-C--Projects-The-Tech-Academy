using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheClub
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hey kid, how old are ya?");
            

            try
            {
                int age = Convert.ToInt32(Console.ReadLine());
                do
                {
                    if (age <= 0)
                    {
                        Console.WriteLine("...What? None of this fun business, alright?! You can't be zero, and now you can't come into the club either! ");
                        Console.ReadLine();
                        return;
                    }
                } while (age <= 0);

                DateTime present = DateTime.Now;
                int age2 = age * -1;
                DateTime access = present.AddYears(age2);
                int accessYear = access.Year;
                Console.WriteLine("Ah, so you were born in " + accessYear + ", then, correct? Come on in, this is an all inclusive club! \n We just don't tolerate negative or zero numbers");
                Console.ReadLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("I may be a bouncer, but I'm still a robot. You gotta tell me your age in an integer, kid \n see ya next time!");
            }

            catch (Exception)
            {
                Console.WriteLine("Sorry, I don't understand you. I can't let you in the club, kid");
            }
            finally
            {
                Console.ReadLine();
            }
           
        }   
    }
}
