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
            string wordToBeGuessed = GenerateWord();
#if DEBUG
            // TODO 6: Use the Show method here
            Console.WriteLine(wordToBeGuessed);
#endif
            int attempt;
            for (attempt = 1; attempt <= MAX_ATTEMPTS; attempt++)
            {
                // TODO 7c: Change the string to LingoWord
                string guess = AskWord(attempt);
                if (!IsValidInput(guess)) continue;
                // TODO 8: Use the AreEqual method from LingoWord here
                if(AreEqual(guess, wordToBeGuessed))
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
        }
        // TODO 9: Remove this method
        private static bool AreEqual(string guess, string wordToBeGuessed)
        {
            if (guess == wordToBeGuessed)
            {
                return true;
            }
            return false;
        }

        // TODO 7b: Change the string argument into LingoWord and modify the body accordingly
        private static bool IsValidInput(string guess)
        {
            if (guess.Length != MAX_WORD_LENGTH)
            {
                Console.WriteLine("Ongeldig woord");
                return false;
            }
            return true;
        }
        // TODO 7a: Change the return type of this method from string to LingoWord and change the code accordingly
        private static string AskWord(int attempt)
        {
            Console.WriteLine("{0}e beurt. Geef een woord", attempt);
            string? userWord = Console.ReadLine();
            return userWord!;
        }
        // TODO 5a: Change the return type of this method from string to LingoWord and modify the code accordingly.
        private static string GenerateWord()
        {
            Random rnd = new Random((int)DateTime.Now.Ticks);
            int idx = rnd.Next(0, wordlist.Length);
            return wordlist[idx];
        }
    }
}
