using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            
                Console.WriteLine("String demo");
                Console.WriteLine("Tech academy website");
                string prefix = "https://";
                string middle = "learncodinganywhere";
                string suffix = ".com";
                Console.WriteLine(prefix + middle + suffix);
                //end concat

                string anger = "what!!!";
                anger = anger.ToUpper();
                Console.WriteLine(anger);
                //end upper
                StringBuilder sb = new StringBuilder();
            sb.Append("So, can I call you tonight?\n");
            sb.Append("That's just how I feel, can you tell me what's real?\n");
            sb.Append("I hear your voice on the phone, now I'm no longer alone\n");
            sb.Append("I always try my best to listen picking up things that I am missing\n");
            sb.Append("Don't go, don't go so easy\n");
            Console.WriteLine(sb);


                Console.ReadLine();
            }
    }
}
