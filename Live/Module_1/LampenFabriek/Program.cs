namespace LampenFabriek;


internal class Program
{
    static void Main(string[] args)
    {
        // Big bang
        Lamp lampObject = new Lamp(400, ConsoleColor.Red);
       // lampObject._intensiteit = 300;
        //lampObject._kleur = ConsoleColor.Yellow;
        lampObject.Aan();


        Lamp lampObject2 = new Lamp();
        lampObject2.Aan();

        Lamp lampObject3 = new Lamp {  Intensiteit = 600, Kleur = ConsoleColor.Green };
        lampObject3.Intensiteit = 4_000_000;
        lampObject3.Aan();

        // Big crunch
    }
}
