namespace Torens;

class Program
{
    static void Main(string[] args)
    {
        //Etage.Elevator.Call(100);

        Etage[] flat = new Etage[40];
        for(int i = 0; i < flat.Length; i++)
        {
            //if (i == 13) continue;
            flat[i] = new Etage { Number = i};
        }

        flat[13].CallElevator();
        flat[20].CallElevator();

        foreach(Etage et in flat)
        {
            et.ShowElevatorStatus();
        }

    }
}
