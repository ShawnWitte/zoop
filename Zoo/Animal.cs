using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public abstract class Animal
    {
        protected string name;
        protected string species;
        protected string type;
        protected string food;
        protected int numOfLegs;

        public void Display()
        {
            Console.WriteLine("This is " + name + ", he is a " + species + ", so that means he's a " + type + " and has " + numOfLegs + " legs.");
        }

        public void Eat() {
            Console.WriteLine(name + " is eating " + food + ".");
        }

    }
}
