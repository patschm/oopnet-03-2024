namespace TheExecutioner;

class Program
{
    static void Main(string[] args)
    {
        Stefan s = new();
        Patrick p = new();

        s.Execute(p.HaalDrankjes);
        s.Execute(Explodeer);
        //p.DoeIets();
    }

    static void Explodeer()
    {
        System.Console.WriteLine("Kaboem!!!");
    }
}
