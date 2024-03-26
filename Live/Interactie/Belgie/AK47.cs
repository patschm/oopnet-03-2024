using Standards;

namespace Belgie;

public class AK47 : IDevice
{
    public void Detecting()
    {
        Vuur();
    }

    public void Vuur()
    {
        Console.WriteLine("De AK47 maait erop los");
    }
}
