using System.Threading.Channels;

namespace LampenFabriek;

internal class DimLamp : Lamp
{
    
    public void DimUp()
    {
        Console.WriteLine($"Dim Up {++Intensiteit}");
    }
    public void DimDown()
    {
        Console.WriteLine($"Dim Down {--Intensiteit}");

    }

    public override void Aan()
    {
        Console.BackgroundColor = Kleur;
        Console.WriteLine($"De dimlamp is nu aan en brandt met {Intensiteit} lumen");
        Console.ResetColor();
    }

    public DimLamp(int intensiteit, ConsoleColor kleur) : base(intensiteit, kleur)
    {
    }
    public DimLamp() : this(500, ConsoleColor.Yellow)
    {

    }
}
