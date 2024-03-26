using Standards;

namespace Veko;

public class Sensor
{
    private List<IDevice> _devices = new List<IDevice>();

    public void Connect(IDevice device)
    {
        _devices.Add(device);   
    }
    public void Detect()
    {
        Console.WriteLine("De detector ziet iets");
        foreach (var device in _devices)
        {
            device.Detecting();
        }
    }
}
