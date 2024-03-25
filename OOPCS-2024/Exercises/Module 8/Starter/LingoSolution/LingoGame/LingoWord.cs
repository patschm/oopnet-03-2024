using System.Collections;

namespace LingoGame
{
    public class LingoWord : List<LingoCharacter>
    {        
        public void Show(IDevice device)
        {
            foreach(LingoCharacter lc in this)
            {
                lc.Draw(device);
            }
        }
        public void CompareTo(LingoWord guess)
        {
            // TODO 2: Use the generic method where needed.
            CharCounter counter = new CharCounter(this);
            for (int i = 0; i < guess.Count; i++)
            {
                LingoCharacter guessChar = guess[i]!;
                foreach (LingoCharacter targetChar in this)
                {
                    if (LingoCharacter.ExactlyEqual(targetChar, guessChar))
                    {
                        counter.DecrementCharacterCount(targetChar);
                        guess[i] = guessChar.ToExact();
                    }
                }
            }
            for (int i = 0; i < guess.Count; i++)
            {
                LingoCharacter guessChar = guess[i]!;
                foreach (LingoCharacter thisChar in this)
                {
                    if (!guessChar.IsExact() &&
                        counter.IsCharacterInWord(guessChar) &&
                        LingoCharacter.PartialEqual(thisChar, guessChar))
                    {
                        counter.DecrementCharacterCount(thisChar);
                        guess[i] = guessChar.ToPartial();
                    }
                }
            }
        }
        public override string ToString()
        {
            char[] chars = new char[this.Count];
            for (int i = 0; i < this.Count; i++)
            {
                chars[i] = this[i].Character;
            }
            return new string(chars);
        }
        public LingoWord(string? word)
        {
            for(int i = 0; i < word?.Length; i++)
            {
               this.Add(new LingoCharacter {
                    Character = word[i],
                    Position = i
                });
            }
        }
        public LingoWord()
        {

        }
    }
}
