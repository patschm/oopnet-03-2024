namespace ConsoleLingo
{
    // TODO 4: Define a class LingoWord with the following members
    // - field internalWord of type array of LingoCharacters
    // - Method Show which draws all individual LingoCharacters
    // - AreEqual which basically does the same as the AreEqual function in the Program class.
    // - Constructor which accepts a variable of type string. Convert each character to a LingoChar
    //   and assigns it to the array of LingoCharacters (internalWord)
    public class LingoWord
    {
        public readonly LingoCharacter[] internalWord;

        public void Show()
        {
            foreach(LingoCharacter c in internalWord)
            {
                c.Draw();
            }
            //for(int i = 0; i < internalWord.Length; i++)
            //{
            //    this.internalWord[i].Draw();
            //}
            Console.WriteLine();
        }
        public bool AreEqual(LingoWord guess)
        {
            for(int i = 0; i < internalWord.Length; i++ )
            {
                if (guess.internalWord[i].character != this.internalWord[i].character)
                {                  
                    return false;
                }
            }          
            return true;
        }
        public LingoWord(string word)
        {
            this.internalWord = new LingoCharacter[word.Length];
            for(int i = 0; i < word.Length;i++)
            {
                LingoCharacter ch = new LingoCharacter(word[i], i);
                this.internalWord[i] = ch;
            }
        }
    }
}
