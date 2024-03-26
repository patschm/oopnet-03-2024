namespace LampenFabriek;

internal class TL : Lamp
{
    public int StartTijd { get; set; } = 3;
    // Override activeert het polymorfisme.
    public sealed override void Aan()
    {
        for (int i = 0; i < StartTijd; i++)
        {
            Console.BackgroundColor = Kleur;
            Console.WriteLine("knipper");
            Task.Delay(500).Wait();
            Console.ResetColor();
           // Console.Beep(5000, 300);
            Task.Delay(500).Wait();
        }
        Console.Clear();
        Console.BackgroundColor = Kleur;
        Console.WriteLine($"De TL is nu aan en brandt met {Intensiteit} lumen");
        Console.ResetColor();
    }

    public TL(int intensiteit, ConsoleColor kleur) : base(intensiteit, kleur)
    {
    }
    public TL() : this(500, ConsoleColor.Yellow)
    {

    }
}
