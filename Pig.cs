using System;
using System.Collections.Generic;
using System.Text;



namespace Zoo
{
    class Pig
    {
        string Name;
        int Age;
        double Weight;
        string Color;
      
        public Pig(string name, int age, double weight, string color)
        {
            Name = name;
            Age = age;
            Weight = weight;
            Color = color;



            
        }
        public void Greeting()
        {
            Console.WriteLine(@"             ._     __,
              |\,../'\
            ,'. .     `.
           .--         '`.
          ( `' ,          ;
          ,`--' _,       ,'\
         ,`.____            `.
        /              `,    |
       '                \,   '
       |                /   /`,
       `,  .           ,` ./  |
       ' `.  ,'        |;,'   ,@
 ______|     |      _________,___________
        `.   `.   ,'
         ,'_,','_,
         `'   `'");
            Console.WriteLine($"This is {Name}. ");
            Console.WriteLine($"{Name} is a pig and is {Age} years old.");
        }
        public void Eat()
        {
            Console.WriteLine($"{Name} eats everything because they are a pig!") ;
        }
        public void Looks()
        {
            Console.WriteLine($"{Name} weighs {Weight} pounds and is {Color}.");
        }

        public void Product()
        {
            Console.WriteLine($"{Name} provides pork for sustinance.");
        }
    }
}
