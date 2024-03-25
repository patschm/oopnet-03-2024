namespace ConsoleLingo
{
    // TODO 2: Create a class ExactCharacter which derives from LingoCharacter.
    // It should draw the character with a green background color and a black foreground color
    // Define a static Create method like the one in LingoCharacter
    public class ExactCharacter : LingoCharacter
    {
        public override void Draw()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(Character);
            Console.ResetColor();
        }
        public static new ExactCharacter Create(char c, int i)
        {
            return new ExactCharacter { Character = c, Position = i };
        }
    }
}
