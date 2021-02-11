using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public class Rabbit
    {
        string Name;
        int Age;
        double Weight;
        string Color;

        public Rabbit(string name, int age, double weight, string color)
        {
            Name = name;
            Age = age;
            Weight = weight;
            Color = color;




        }
        public void Greeting()
        {
            Console.WriteLine(@"     / \
    / _ \
   | / \ |
   ||   || _______
   ||   || |\     \
   ||   || ||\     \
   ||   || || \    |
   ||   || ||  \__/
   ||   || ||   ||
    \\_/ \_/ \_//
   /   _     _   \
  /               \
  |    O     O    |
  |   \  ___  /   |
 /     \ \_/ /     \
/  -----  |  -----  \
|     \__/|\__/     |
\       |_|_|       /
 \_____       _____/
       \     /
       |     |");
            Console.WriteLine($"This is {Name}. ");
            Console.WriteLine($"{Name} is a rabbit is {Age} years old.");
        }
        public void Eat()
        {
            Console.WriteLine($"{Name} eats humans!");
        }
        public void Looks()
        {
            Console.WriteLine($"{Name} weighs {Weight} pounds and is {Color}.");
        }

        public void Product()
        {
            Console.WriteLine($"{Name} provides meet for stew.");
        }
    }
        
}
