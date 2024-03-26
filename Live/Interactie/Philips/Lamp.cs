using Standards;

namespace Philips;

public class Lamp: IDevice
{
    public void Aan()
    {
        Console.WriteLine("De lamp gaat aan");
    }

    public void Detecting()
    {
        Aan();
    }
}
