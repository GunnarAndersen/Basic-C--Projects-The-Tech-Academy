using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorChaining
{
    class Program
    {
        static void Main(string[] args)
        {
            const string dog1Name = "Amy";
            var BlackLab = new Dog(dog1Name, 7);

            const string dog2Name = "Henri";
            var Beagle = new Dog(dog2Name, 2);

            
        }
    }
}
