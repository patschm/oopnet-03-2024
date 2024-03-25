using System;

namespace ConsoleLingo
{
    public class LingoCharacter
    {
        // TODO 1: Make sure that this character field only contains lowercase characters.
        // Refactor the code
        // Hint: Check char's members (char.)
        private char character;
        // TODO 2: Make sure that position  cannot be less than 0
        private int position;

        public char Character
        {
            get
            {
                return character;
            }
            set
            {
                character = char.ToLower(value);
            }
        }

        public int Position
        {
            get
            {
                return position;
            }
            set
            {
                if (value >= 0)
                {
                    position = value;
                }
            }
        }
        // TODO 3: Make sure that these properties are used instead of the fields. 

        public void Draw()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(Character);
            Console.ResetColor();
        }

        public LingoCharacter(char c, int pos)
        {
            this.Position = pos;
            this.Character = c;
        }
    }
}
