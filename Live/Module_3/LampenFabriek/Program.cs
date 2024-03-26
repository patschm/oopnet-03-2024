namespace LampenFabriek;


internal class Program
{
    static void Main(string[] args)
    {
        // Big bang
        //Lamp lampObject = new Lamp(400, ConsoleColor.Red);
       // lampObject._intensiteit = 300;
        //lampObject._kleur = ConsoleColor.Yellow;
       // lampObject.Aan();


        Lamp lampObject2 = new TL { StartTijd = 4 };
        lampObject2.Aan();

        Lamp lampObject3 = new DimLamp {  Intensiteit = 600, Kleur = ConsoleColor.Green };
        lampObject3.Aan();
        (lampObject3 as DimLamp)?.DimUp();

        // Big crunch
    }
}
