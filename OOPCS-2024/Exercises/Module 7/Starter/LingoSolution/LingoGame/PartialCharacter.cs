namespace LingoGame
{
    public class PartialCharacter : LingoCharacter
    {
        // TODO 2c: Modify the Draw method to accept an argument of type IDevice
        // In the function replace the existing code for the DrawPartial method.
        public override void Draw()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(Character);
            Console.ResetColor();
        }

    }
}
