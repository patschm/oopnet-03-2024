namespace ConsoleLingo
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

        const int MAX_WORD_LENGTH = 5;
        const int MAX_ATTEMPTS = 5;

        static void Main(string[] args)
        {
            // TODO 5b: Change the string to LingoWord
            LingoWord wordToBeGuessed = GenerateWord();
#if DEBUG
            // TODO 6: Use the Show method here
            wordToBeGuessed.Show();
#endif
            int attempt;
            for (attempt = 1; attempt <= MAX_ATTEMPTS; attempt++)
            {
                // TODO 7c: Change the string to LingoWord
                LingoWord guess = AskWord(attempt);
                if (!IsValidInput(guess)) continue;
                // TODO 8: Use the AreEqual method from LingoWord here
                if (wordToBeGuessed.AreEqual(guess))
                {
                    Console.WriteLine("Geraden");
                    break;
                }
                else
                {
                    Console.WriteLine("Niet juist");
                }
            }
            ShowIQ(attempt);

            Console.ReadLine();
        }

        private static void ShowIQ(int attempt)
        {
            // TODO 2: Rewrite this code by using the IQ enumeration in IQ.cs
            if (attempt < 5)
            {
                IQ iq = (IQ)attempt;
                Console.WriteLine("Your IQ level is {0} ", iq);
            }
            else
            {
                Console.WriteLine("Your IQ level is so low that it cannot be expressed ");
            }
        }
        // TODO 9: Remove this method

        // TODO 7b: Change the string argument into LingoWord and modify the body accordingly
        private static bool IsValidInput(LingoWord guess)
        {
            if (guess.internalWord.Length != MAX_WORD_LENGTH)
            {
                Console.WriteLine("Ongeldig woord");
                return false;
            }
            return true;
        }
        // TODO 7a: Change the return type of this method from string to LingoWord and change the code accordingly
        private static LingoWord AskWord(int attempt)
        {
            Console.WriteLine("{0}e beurt. Geef een woord", attempt);
            string? userWord = Console.ReadLine();
            return new LingoWord(userWord!);
        }
        // TODO 5a: Change the return type of this method from string to LingoWord and modify the code accordingly.
        private static LingoWord GenerateWord()
        {
            Random rnd = new Random((int)DateTime.Now.Ticks);
            int idx = rnd.Next(0, wordlist.Length);
            return new LingoWord(wordlist[idx]);
        }
    }
}
