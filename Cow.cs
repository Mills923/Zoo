using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    class Cow
    {
        string Name;
        int Age;
        double Weight;
        string Color;

        public Cow(string name, int age, double weight, string color)
        {
            Name = name;
            Age = age;
            Weight = weight;
            Color = color;




        }
        public void Greeting()
        {
            Console.WriteLine(@"              (      )
              ~(^^^^)~
               ) @@ \~_          |\
              /     | \        \~ /
             ( 0  0  ) \        | |
              ---___/~  \       | |
               /'__/ |   ~-_____/ |
o          _   ~----~      ___---~
  O       //     |         |
         ((~\  _|         -|
   o  O //-_ \/ |        ~  |
        ^   \_ /         ~  |
               |          ~ |
               |     /     ~ |
               |     (       |
                \     \      /\
               / -_____-\   \ ~~-*
               |  /       \  \
               / /         / /
             /~  |       /~  |
             ~~~~        ~~~~");
            Console.WriteLine($"This is {Name}. ");
            Console.WriteLine($"{Name} is a cow and is {Age} years old.");
        }
        public void Eat()
        {
            Console.WriteLine($"{Name} eats grass because they are a cow!");
        }
        public void Looks()
        {
            Console.WriteLine($"{Name} weighs {Weight} pounds and is {Color}.");
        }

        public void Product()
        {
            Console.WriteLine($"{Name} provides beef for sustinance.");
        }
    }
}
