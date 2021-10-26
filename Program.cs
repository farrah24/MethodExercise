using System;

namespace MethodExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string YourName;
            string FaveColor;
            string FaveAnimal;
            string FaveBand;

            Console.WriteLine("Whats your name?");
            YourName = Console.ReadLine();

            Console.WriteLine("Whats your favorite color?");
            FaveColor = Console.ReadLine();

            Console.WriteLine("Whats your favorite animal?");
            FaveAnimal = Console.ReadLine();

            Console.WriteLine("Whats your favorite Band?");
            FaveBand = Console.ReadLine();


            Console.WriteLine($"I bumped my head and forgot my name was {YourName}.");
            Console.WriteLine($"I tried dying my hair red but it turned {FaveColor} instead!");
            Console.WriteLine($"I have no {FaveAnimal}but my son loves dogs.");
            Console.WriteLine($"I went to NOLA looking for {FaveBand} but I only saw BB King.");
           


        }
    }
}
