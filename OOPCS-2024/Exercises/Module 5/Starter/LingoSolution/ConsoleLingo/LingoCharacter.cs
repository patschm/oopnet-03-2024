using System;

namespace ConsoleLingo
{
    public class LingoCharacter
    {
        private char character;
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

        // TODO 1a: Create a method that checks if 2 LingoCharacters are exactly equal
        // based on position and character
      
        
        // TODO 1b: Create a method that checks if 2 LingoCharacters are partial equal
        // based on character and not position
      

        public void Draw()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(Character);
            Console.ResetColor();
        }

        // TODO 2a: We're trying to get rid of the constructor.
        // Create a (factory) method that creates LingoCharacter object.
        
        
        // TODO 2b: Remove the constructor and change the code accordingly
        public LingoCharacter(char c, int pos)
        {
            Character = c;
            Position = pos;
        }
    }
}
