namespace ConsoleLingo
{
    // TODO 0: We'll try to take advantage of polymorphism by letting derived classes from LingoCharacter
    // override the draw method. There will be 2 derived classes:
    //    - ExactCharacter which draws the right characters in the right place. 
    //    - PartialCharacter which draws the character if it is part of the word but not in the right place

    // TODO 1: Make this class ready for polymorphism
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
        public static bool ExactlyEqual(LingoCharacter a, LingoCharacter b)
        {
            return a.Character == b.Character && a.Position == b.Position;
        }
        public static bool PartialEqual(LingoCharacter a, LingoCharacter b)
        {
            return a.Character == b.Character && a.Position != b.Position;
        }
        public virtual void Draw()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(Character);
            Console.ResetColor();
        }
        
        public static LingoCharacter Create(char c, int i)
        {
            return new LingoCharacter { Character = c, Position = i };
        }
    }
}
