﻿namespace ConsoleLingo
{
    class Program
    {
        static string[] wordlist = {"appel", "actie", "breed", "blind", "cadet", "creme",
                                    "deren", "dweil", "elven", "engel", "feest", "flora", "grote",
                                    "gebak", "hamer", "hoofd", "index", "icoon", "jawel", "japon",
                                    "kraan", "kleur", "licht", "laser", "motor", "markt", "nodig", "neven",
                                    "oases", "onwel", "polis", "preek", "quota", "quark", "ruzie", "schat",
                                    "treur", "typen", "uniek", "ultra", "vloer", "vorst", "wreed", "wazig",
                                    "xenon", "yacht", "yucca", "zomer", "zagen"};
        static void Main(string[] args)
        {
            Random rnd = new Random((int)DateTime.Now.Ticks);
            int idx = rnd.Next(0, wordlist.Length);
            string wordToBeGuessed = wordlist[idx];
#if DEBUG
            Console.WriteLine(wordToBeGuessed);
#endif
            // TODO 1: A player has to guess the generated word. In order to do that he has 5 attempts
            // In each attempt the user must enter a word with 5 characters. If the input doesn't meet this 
            // requirement the attempt is failed and the user continues with the next attempt
            // If the player guesses the word the game stops and an IQ level is presented based on the number
            // of attempts.
            // The following IQ levels are presented:
            //   1: Your IQ level is brilliant
            //   2: Your IQ level is bright
            //   3:Your IQ level is average
            //   4:Your IQ level is mediocre
            //   5:Your IQ level is stupid
            //   more: Your IQ level is so low that it cannot be expressed
            // Write the program.
            const int MAX_WORD_LENGTH = 5;
            const int MAX_ATTEMPTS = 5;

            int attempt;
            for (attempt = 1; attempt <= MAX_ATTEMPTS; attempt++)
            {
                Console.WriteLine("{0}e beurt. Geef een woord", attempt);
                string? guess = Console.ReadLine();
                if (guess!.Length != MAX_WORD_LENGTH)
                {
                    Console.WriteLine("Ongeldig woord");
                    continue;
                }
                if (guess == wordToBeGuessed)
                {
                    Console.WriteLine("Geraden");
                    break;
                }
                Console.WriteLine("Niet juist");
            }
            switch (attempt)
            {
                case 1:
                    Console.WriteLine("Your IQ level is brilliant");
                    break;
                case 2:
                    Console.WriteLine("Your IQ level is bright");
                    break;
                case 3:
                    Console.WriteLine("Your IQ level is average");
                    break;
                case 4:
                    Console.WriteLine("Your IQ level is mediocre");
                    break;
                case 5:
                    Console.WriteLine("Your IQ level is stupid");
                    break;
                default:
                    Console.WriteLine("Your IQ level is so low that it cannot be expressed ");
                    break;
            }
            Console.ReadLine();
        }
    }
}

