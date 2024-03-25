namespace ConsoleLingo
{
    // TODO 3: Define a class LingoCharacter with the following members
    // - public field character of type char
    // - public field position of type int
    // - public method Draw that draws the character on the screen
    // - constructor to provide the fields with a value.
    public class LingoCharacter
    {
        public char character;
        public int position;

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
