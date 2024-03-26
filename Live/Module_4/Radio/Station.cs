
namespace Radio;


public delegate void OntvangstMethod(string msg);

public class Station
{
    public event OntvangstMethod? subscribers;

    public void Broadcast()
    {
        System.Console.WriteLine("Radiostation zendt nu uit");
        subscribers?.Invoke("Hallo allemaal");
    }
}
