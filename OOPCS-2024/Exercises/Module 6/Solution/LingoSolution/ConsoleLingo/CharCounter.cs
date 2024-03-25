namespace ConsoleLingo
{
    class CharCounter
    {
        private Dictionary<char, int> charCount = new Dictionary<char, int>();

        private void InitCharCount(LingoWord? word)
        { 
            if (word == null) return;
            for (int i = 0; i < word.Count; i++)
            {
                char character = word[i]!.Character;
                if (charCount.ContainsKey(character))
                {
                    charCount[character]++;
                }
                else
                {
                    charCount.Add(character, 1);
                }
            }
        }
        public void DecrementCharacterCount(LingoCharacter character)
        {
            if (charCount.ContainsKey(character.Character) && charCount[character.Character] > 0)
            {
                charCount[character.Character]--;
            }
        }
        public bool IsCharacterInWord(LingoCharacter character)
        {
            return charCount.ContainsKey(character.Character) && charCount[character.Character] > 0;
        }

        public CharCounter(LingoWord word)
        {
            InitCharCount(word);
        }
    }
}
