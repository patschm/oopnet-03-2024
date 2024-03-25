namespace Torens;

public class Etage
{
    // Instance member. Kun je alleen bij als je een instantie.
    public int Number {get; set;}
    // Class Member (static)
    public static Lift Elevator { get; set; } = new Lift();

    public  void CallElevator()
    {
        Elevator.Call(this.Number);
    }

    public void ShowElevatorStatus()
    {
        System.Console.WriteLine($"Hij is op de {Etage.Elevator.Current} verdieping.");
    }

}

public class Lift
{
    public int Current { get; set; } = 0;

    public void Call(int targetFloor)
    {
        System.Console.WriteLine("Zzzzzzzz");
        Current = targetFloor;
    }
}