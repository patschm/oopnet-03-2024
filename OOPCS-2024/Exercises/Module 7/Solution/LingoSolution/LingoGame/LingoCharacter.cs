namespace LingoGame
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
        public static bool ExactlyEqual(LingoCharacter a, LingoCharacter b)
        {
            return a.Character == b.Character && a.Position == b.Position;
        }
        public static bool PartialEqual(LingoCharacter a, LingoCharacter b)
        {
            return a.Character == b.Character && a.Position != b.Position;
        }
        // TODO 2a: Modify the Draw method to accept an argument of type IDevice
        // In the function replace the existing code for the DrawDefault method. (Comment the existing code. You'll need it later)
        public virtual void Draw(IDevice device)
        {
            device.DrawDefault(Character);
            
        }
        public static LingoCharacter Create(char c, int pos)
        {
            return new LingoCharacter {Character = c, Position = pos};
        }
        public virtual LingoCharacter ToExact()
        {
            return new ExactCharacter { Character = this.Character, Position = this.position };
        }
        public virtual LingoCharacter ToPartial()
        {
            return new PartialCharacter { Character = this.Character, Position = this.position };
        }
    }
}
