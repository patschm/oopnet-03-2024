namespace LampenFabriek;

internal class Lamp
{
    // Eigenschappen slaan we op in fields
    private readonly int _intensiteit = 500;
    //private ConsoleColor _kleur = ConsoleColor.Yellow;

    // Ouewets C++-isch
    // Doen we niet in .NET
    //public void SetIntensiteit(int intensiteit)
    //{
    //    if (intensiteit >= 0 && intensiteit < 1000)
    //    {
    //        _intensiteit = intensiteit;
    //    }
    //}
    //public int GetIntensiteit()
    //{
    //    return _intensiteit;
    //}

    // Auto generating property. Genereert zijn eigne private field
    public ConsoleColor Kleur { get; set; } = ConsoleColor.Yellow;

    // Propetries. Om _gecontroleerd_ toegang tot de fields te regelen
    // Encapsulation
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

    // Gedrag leggen we vast in methodes.
    public void Aan()
    {
        Console.BackgroundColor = Kleur;
        Console.WriteLine($"De lamp is nu aan en brandt met {Intensiteit} lumen");
        Console.ResetColor();
    }

    // Constructors gebruik je om fields een initiele waarde te geven.
    public Lamp(int intensiteit, ConsoleColor kleur)
    {
        Intensiteit = intensiteit;
       Kleur = kleur;
    }
    public Lamp() : this(500, ConsoleColor.Yellow)
    {

    }
}
