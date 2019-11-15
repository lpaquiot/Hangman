using System;

namespace Hangman
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string[] guessWords = new string[5];

            guessWords[0] = "Hello";
            guessWords[1] = "Goodbye";
            guessWords[2] = "Super";
            guessWords[3] = "Natural";
            guessWords[4] = "Jacket";

            Random r = new Random();
            var word = r.Next(0, 4);
            string mysteryWord = guessWords[word];
            
            char[] guess = new char[mysteryWord.Length];
            for (int p = 0; p < mysteryWord.Length; p++)
                guess[p] = '*';
            int i = 0;
            int chance = 5;
          
            Console.WriteLine("The word contains {0} letters.", mysteryWord.Length);
            //Console.WriteLine(mysteryWord);
            Console.WriteLine("Enter your guess: ");

            while (i < chance)
            {

                char playerGuess = char.Parse(Console.ReadLine());
                for (int j = 0; j < mysteryWord.Length; j++)
                {
                    if (playerGuess == mysteryWord[j])
                        guess[j] = playerGuess;
<<<<<<< Updated upstream
                    //else
                    if (playerGuess != mysteryWord[j])
                        Console.WriteLine("Try again");
=======
                    else
                    //if (playerGuess != mysteryWord[j])
                    Console.WriteLine("Try again"); 
>>>>>>> Stashed changes


                }
                
                Console.WriteLine(guess);
                
                i++;
               Console.WriteLine("You have {0} tries left", chance -i);

            }
if (i == chance)
                {
                    Console.WriteLine("You lost!");
                    Console.WriteLine("The word is " + mysteryWord);
                }

<<<<<<< Updated upstream

=======
 
>>>>>>> Stashed changes
            
        }
    }
}

