using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndListExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, please select an index choice. \n To do so, put in an integer between 0 and 4.");
            String[] s1 = new String[5] { "honesty", "and", "love", "could", "have" };

            int i = 0;
            i = Convert.ToInt32(Console.ReadLine());
            if (i < 4)
            {
                Console.WriteLine(s1[i]);
            }
            else
            {
                Console.WriteLine("Error, too big. Restart the program, you clearly didn't follow my directions!");
                Console.ReadLine();
            }




            Console.WriteLine("Hello, please select an index choice. \n To do so, put in an integer between 0 and 4.");
            int[] i1 = new int[5] { 0, 1, 2, 3, 4 };

            int j = 0;
            j = Convert.ToInt32(Console.ReadLine());
            if (j < 4)
            {
                Console.WriteLine(i1[j]);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Error, too big. Restart the program, you clearly didn't follow my directions!");
                Console.ReadLine();
            }

            Console.WriteLine("Hello, please select an index choice. \n To do so, put in an integer between 0 and 13.");


            List<string> strList = new List<string>();
            strList.Add("Patiently");
            strList.Add("She");
            strList.Add("Says");
            strList.Add("I");
            strList.Add("Have");
            strList.Add("Been");
            strList.Add("Thinking");
            strList.Add("Of");
            strList.Add("What");
            strList.Add("She's");
            strList.Add("Gonna");
            strList.Add("Do");
            strList.Add("All");
            strList.Add("Alone");


            int s = 0;
            s = Convert.ToInt32(Console.ReadLine());
            if (s < 14)
            {
                Console.WriteLine(strList[s]);
            }
            else
            {
                Console.WriteLine("Error, too big. Restart the program, you clearly didn't follow my directions!");
                Console.ReadLine();
            }

            Console.ReadLine();
            // [0] to [13] 14 items on list



        }
    }

}
