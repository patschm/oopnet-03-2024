namespace LampenFabriek;

internal abstract class Lamp
{
    private int _intensiteit = 500;
    public ConsoleColor Kleur { get; set; } = ConsoleColor.Yellow;
    public int Intensiteit
    {
        set
        {
            if (value >= 0 && value < 1000)
            {
                _intensiteit = value;
            }
        }
        get
        {
            return _intensiteit;
        }
    }
    // Virtual maakt dit gederag polymorf-ready
    // Bij virtual is een override _optioneel_
    // Indien dit niet gewenst is, kun je beter abstract gebruiken (met alle gevolgen vandien)
    public abstract void Aan();
    //{
    //    Console.BackgroundColor = Kleur;
    //    Console.WriteLine($"De lamp is nu aan en brandt met {Intensiteit} lumen");
    //    Console.ResetColor();
    //}
    public Lamp(int intensiteit, ConsoleColor kleur)
    {
        Intensiteit = intensiteit;
       Kleur = kleur;
    }
    public Lamp() : this(500, ConsoleColor.Yellow)
    {

    }
}
