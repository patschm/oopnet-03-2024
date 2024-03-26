
namespace TheFirm;

public class Stephan : Employee
{
    public void DoetIets()
    {
        System.Console.WriteLine("Stephan doet eerst iets en dan denkt hij");
    }

    public override void Werkt()
    {
        DoetIets();
    }
}
