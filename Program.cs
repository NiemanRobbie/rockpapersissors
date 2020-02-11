using System;

namespace rockpapersissors
{
    class Program
    {
        static void Main(string[] args)
        {
            // Greet User Into The Program
            Console.WriteLine("Welcome to RPS! Lets Play!");
            // Choose between rock, paper or scissors
            Console.WriteLine("Choose Between Rock, Paper, Scissors");
            var choice = Console.ReadLine().ToLower();
            // From random choose what action the computer wants to play
            Random rand = new Random();
            string[] firstChoice = { "rock", "paper", "scissors" };
            int fRandom = rand.Next(firstChoice.Length);
            //Print the randomly selected item
            Console.WriteLine("RPS Decison ");
            Console.WriteLine("Choice 1: " + firstChoice[fRandom]);

            // Print a win or lose message
            Console.WriteLine("Outcome of Game:");
            if (choice == "scissors" && firstChoice[fRandom] == "paper") ;
            Console.WriteLine("Winner");
            if (choice == "rock" && firstChoice[fRandom] == "scissors") ;
            Console.WriteLine("Winner");
            if (choice == "paper" && firstChoice[fRandom] == "rock") ;
            Console.WriteLine("Winner!");
            if (choice == "scissors")
            {
                if (firstChoice[fRandom] == "rock")
                {
                    Console.WriteLine("Loser");
                    if (choice == "rock")
                    {
                        if (firstChoice[fRandom] == "paper")
                            Console.WriteLine("Loser");
                        if (choice == "paper")
                        {
                            if (firstChoice[fRandom] == "rock")
                                Console.WriteLine("Loser");
                        }
                    }

                    {




                    }
















                    // Add validation around the user input





                }
            }
        }
    }

}
