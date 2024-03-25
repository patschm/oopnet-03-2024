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
            LingoWord wordToBeGuessed = GenerateWord();
#if DEBUG
            wordToBeGuessed.Show();
#endif
            int attempt;
            for (attempt = 1; attempt <= MAX_ATTEMPTS; attempt++)
            {
                LingoWord guess = AskWord(attempt);
                if (!IsValidInput(guess)) continue;
                bool isGuessed = LingoWord.AreEqual(wordToBeGuessed, guess);
                guess.Show();
                if (isGuessed)
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
            if (attempt <= 5)
            {
                IQ iq = (IQ)attempt;
                Console.WriteLine("Your IQ level is {0} ", iq);
            }
            else
            {
                Console.WriteLine("Your IQ level is so low that it cannot be expressed ");
            }
        }
        private static bool IsValidInput(LingoWord guess)
        {
            if (guess.internalWord.Length != MAX_WORD_LENGTH)
            {
                Console.WriteLine("Ongeldig woord");
                return false;
            }
            return true;
        }
        private static LingoWord AskWord(int attempt)
        {
            Console.WriteLine("{0}e beurt. Geef een woord", attempt);
            string? userWord = Console.ReadLine();
            return new LingoWord(userWord);
        }
        private static LingoWord GenerateWord()
        {
            Random rnd = new Random((int)DateTime.Now.Ticks);
            int idx = rnd.Next(0, wordlist.Length);
            return new LingoWord(wordlist[idx]);
        }
    }
}

