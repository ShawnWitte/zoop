using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Reptile : Animal
    {
        public Reptile(string name, string species, string food, int numOfLegs)
        {
            this.name = name;
            this.species = species;
            this.food = food;
            this.numOfLegs = numOfLegs;
            type = "reptile";
        }

        public void WarmUp(string choice)
        {
            if (choice == "yes")
            {
                Random rnd = new Random();
                int num = rnd.Next(101);
                if (num > 50)
                {
                    Console.WriteLine("Ayeeee we lit!");
                    Eat();
                }
                else
                {
                    Console.WriteLine("This boy cold af, he ain't eating this time.");
                }
            }
            if (choice == "no")
            {
                Console.WriteLine("Nou dan sterft hij lekker uit.");
            }
        }

        public void WarmUp2(string choice)
        {
            for(int i = 0; i < 2; i++)
            {
                
                Console.WriteLine("Are you sure?");
                Console.ReadLine();
                
            }
            Console.WriteLine("He's all warmed up now");
            Eat();
            
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
