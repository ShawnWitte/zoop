using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Objects
            Mammal lion = new Mammal("Loek", "lion", "Bambi", 4);
            Mammal giraffe = new Mammal("Gerard", "giraffe", "leaves", 4);
            Reptile snake = new Reptile("Snek", "snake", "Kroki special chips", 0);
            Reptile croc = new Reptile("Kronk", "crocodile", "nasi", 4);
            Zoo zoop = new Zoo("Zootopia");

            //Zoo
            zoop.Display();
            Console.ReadLine();

            //Lion
            lion.Display();
            lion.Eat();
            Console.ReadLine();

            //Snake
            Console.WriteLine();
            Console.WriteLine("Oh... what do we have here?");
            Console.ReadLine();
            snake.Display();

            Console.WriteLine("Should " + snake.GetName() + " eat? He might have to warm up first.");
            string choice = Convert.ToString(Console.ReadLine());
            snake.WarmUp(choice);

            //Crocodile
            Console.WriteLine();
            Console.WriteLine("Should Mr. " + croc.GetName() + " eat? He's pretty cold.");
            string choice2 = Convert.ToString(Console.ReadLine());
            croc.WarmUp2(choice2);

            Console.ReadLine();










        }
        
    }
}
