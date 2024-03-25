namespace ConsoleLingo
{
    // TODO 3: Create a class PartialCharacter which derives from LingoCharacter.
    // It should draw the character with a yellow background color and a black foreground color
    public class PartialCharacter : LingoCharacter
    {
        public override void Draw()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(Character);
            Console.ResetColor();
        }
        public static new PartialCharacter Create(char c, int i)
        {
            return new PartialCharacter { Character = c, Position = i };
        }
    }
}
