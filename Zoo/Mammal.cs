using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Mammal : Animal
    {
        
        public Mammal(string name, string species, string food, int numOfLegs)
        {
            this.name = name;
            this.species = species;
            this.food = food;
            this.numOfLegs = numOfLegs;
            type = "mammal";
        }

        public string GetName()
        {
            return this.name;
        }

        public string GetFood()
        {
            return this.food;
        }

        public int GetNumOfLegs()
        {
            return this.numOfLegs;
        }
    }
}
