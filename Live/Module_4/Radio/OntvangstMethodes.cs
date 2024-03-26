namespace Radio;

public static class OntvangstMethodes
{
    public static void ViaEther(string msg)
    {
        System.Console.WriteLine($"Via ether ontvangen: {msg}");
    }
    public static void ViaKabel(string msg)
    {
        System.Console.WriteLine($"Via kabel ontvangen: {msg}");
    }
    public static void ViaSMS(string msg)
    {
        System.Console.WriteLine($"Via SMS ontvangen: {msg}");
    }
    public static void ViaPostduif(string msg)
    {
        System.Console.WriteLine($"Via postduif ontvangen: {msg}");
    }
    public static void ViaRooksignalen(string msg)
    {
        System.Console.WriteLine($"Via Rooksignalen ontvangen: {msg}");
    }
}
