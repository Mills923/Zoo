using System;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Would you like to meet our animals in the zoo? Type yes or no");
            string answer = Console.ReadLine();
            if (answer =="yes")
            {
                Pig Luna = new Pig("Luna", 27, 160, "pink");
                Luna.Greeting();
                Luna.Eat();
                Luna.Looks();
                Luna.Product();

                Console.WriteLine("\n Would you like to meet the next animal in the zoo? Type yes or no");
                answer = Console.ReadLine();

                if (answer == "yes")
                {
                    Cow Ally = new Cow("Ally", 5, 300, "pink with black spots");
                    Ally.Greeting();
                    Ally.Eat();
                    Ally.Looks();
                    Ally.Product();

                    Console.WriteLine("\n Would you like to meet the next animal in the zoo? Type yes or no");
                    answer = Console.ReadLine();
                    if (answer == "yes")
                    {
                        Rabbit Ranciel = new Rabbit("Ranciel", 6, 45, "grey");
                        Ranciel.Greeting();
                        Ranciel.Eat();
                        Ranciel.Looks();
                        Ranciel.Product();
                        Console.WriteLine("\n Would you like to meet the next animal in the zoo? Type yes or no");
                        answer = Console.ReadLine();
                        if (answer == "yes")
                        {
                            Chicken Ellodie = new Chicken("Ellodie", 2, 10, "black");
                            Ellodie.Greeting();
                            Ellodie.Eat();
                            Ellodie.Looks();
                            Ellodie.Product();
                            Console.WriteLine("\n That is all the animals we have available today! Thank you for visiting our zoo!");
                            Environment.Exit(0);

                        }
                        else
                        {
                            Console.WriteLine("Thank you for visting");
                            Environment.Exit(0);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Thank you for visting");
                        Environment.Exit(0);

                    }
                }
                else
                {
                    Console.WriteLine("Thank you for visting");
                    Environment.Exit(0);
                }
            }
            else
            {
                Console.WriteLine("Thank you for visting");
                Environment.Exit(0);
            }
         

           

         

        }
    }
}
