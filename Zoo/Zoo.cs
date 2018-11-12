using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Zoo
    {
        protected string name;

        public Zoo(string name)
        {
            this.name = name;
        }
        public void Display()
        {
            Console.WriteLine("Welcome to " + name + " bitchboy");
        }
    }
}
