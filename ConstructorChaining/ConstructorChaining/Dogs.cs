using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorChaining
{
    public class Dog
    {
        public string Name;
        public int Age;

        public Dog() : this("", 0)
        {
        }
        public Dog(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
            
        }
        public Dog(int Age) : this("", Age)
        {
        }
        public Dog(string Name) : this(Name, 0)
        {
        }
        

    }
}
