using System;

namespace ConsoleLingo
{
    public class LingoWord
    {
        public readonly LingoCharacter[] internalWord;

        /// <summary>
        /// Indexer to make LingoWord behave like an array
        /// </summary>
        /// <param name="idx">index of collection</param>
        /// <returns>LingoCharacter</returns>
        public LingoCharacter? this[int idx]
        {
            get
            {
                if (idx >= 0 && idx < internalWord.Length)
                {
                    return internalWord[idx];
                }
                return null;
            }
            set
            {
                if (idx >= 0 && idx < internalWord.Length)
                {
                    internalWord[idx] = value!;
                }
            }
        }
        public int Count
        {
            get
            {
                return internalWord.Length;
            }
        }
        public void Show()
        {
            foreach(LingoCharacter lg in internalWord)
            {
                lg.Draw();
            }
            Console.WriteLine();
        }

        // TODO 3: Since the AreEqual technically doesn't belong to a specific
        // LingoWord (just like the + sign doesn't belong to any number) remodel
        // this method to a static one
        public static bool AreEqual(LingoWord wordToBeGuessed, LingoWord guess)
        {
            bool[] correctPositions = new bool[wordToBeGuessed.Count];
            for (int i = 0; i < guess.Count; i++)
            {
                correctPositions[i] = LingoCharacter.AreExactlyEqual(guess[i], wordToBeGuessed[i]);
            }
            return IsWordCorrect(correctPositions);
        }
        private static bool IsWordCorrect(bool[] correctPositions)
        {
            foreach (bool isGuessed in correctPositions)
            {
                if (!isGuessed)
                {
                    return false;
                }
            }
            return true;
        }

        public LingoWord(string? word)
        {
            internalWord = new LingoCharacter[word!.Length];
            for (int i = 0; i < word.Length; i++)
            {
                LingoCharacter ch = LingoCharacter.Create(word[i], i);
                this.internalWord[i] = ch;
            }
        }
    }
}
