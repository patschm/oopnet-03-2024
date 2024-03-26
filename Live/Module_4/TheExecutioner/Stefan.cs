namespace TheExecutioner;

public delegate void Opdracht();

public class Stefan
{
    public void Execute(Opdracht iets)
    {
        System.Console.WriteLine("Stefan voert het volgende uit");
        iets();
    }
}
