using System;

namespace ConsoleLingo
{
    public class LingoCharacter
    {
        // TODO 1: Make sure that this character field only contains lowercase characters.
        // Refactor the code
        // Hint: Check char's members (char.)
        public char character;
        // TODO 2: Make sure that position  cannot be less than 0
        public int position;

        // TODO 3: Make sure that these properties are used instead of the fields. 
        public void Draw()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(character);
            Console.ResetColor();
        }

        public LingoCharacter(char c, int pos)
        {
            this.position = pos;
            this.character = c;
        }
    }
}
