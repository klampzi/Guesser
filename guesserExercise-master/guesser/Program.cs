using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guesser
{
    class Guesser
    {
        // the "const" keyword makes the value of the variable final, meaning it can never be modified
        // a variable with "const" acts also as if it had the "static" modifier, meaning it can be accessed without needing to instantiate an object
        const int MaxTrials = 10;
       

        static void Main(string[] args)
        {
            /* TO DO: here is where you add your code! */
            string currentGuess;
            bool doneDeal = false;
            string correctAnswer = "arnold";
            int guesses = 0;

            Console.WriteLine("Guess a name!");

            while (doneDeal == false && guesses < MaxTrials)
            {
                currentGuess = Console.ReadLine().ToLower();
                
                if(currentGuess == correctAnswer)
                {
                    Console.WriteLine("You guessed right!");
                    Console.WriteLine("Press enter to exit");
                    Console.ReadLine();
                    doneDeal = true;
                }
                else
                {
                    Console.WriteLine("WRONG! try again!");
                    guesses++;
                }

                if(guesses == 3)
                {
                    Console.WriteLine("The answer starts with an 'a'");
                }

                if(guesses == 6)
                {
                    Console.WriteLine("The answer ends with a 'd'");
                }

                if(guesses == 9)
                {
                    Console.WriteLine("Last guess now!");
                    Console.WriteLine("He is a famous Austrian actor");
                }
            }
            if(guesses == MaxTrials)
            {
                Console.WriteLine("That's it. You failed!");
                Console.ReadLine();
                Environment.Exit(0);
            }
        }
    }
}
