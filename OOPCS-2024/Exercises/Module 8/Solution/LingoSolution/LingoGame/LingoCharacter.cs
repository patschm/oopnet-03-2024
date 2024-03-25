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
        public virtual void Draw(IDevice device)
        {
            device.DrawDefault(Character);
            
        }
        // TODO 1: Modify the following methods to a generic method.
        public T  To<T>() where T: LingoCharacter, new()
        {
            return new T { Character = this.Character, Position = this.position };
        }
    }
}
