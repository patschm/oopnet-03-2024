namespace HetCern;

internal delegate int MathDel(int x, int y);

internal class WillemKlein
{
    public void Bereken(MathDel bereken, int a = 26, int b = 16)
    {
        Console.WriteLine("Willem Klein gaat rekenen....");

        int result = bereken(a, b);

        Console.WriteLine($"Hoera! Het antwoord is {result}");
    }
}
