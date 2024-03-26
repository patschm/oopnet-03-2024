using Standards;

namespace Veko;

public class Sensor
{
    private List<IDevice> _devices = new List<IDevice>();
    public event SensorHandler? Detecting;

    public void Connect(IDevice device)
    {
        _devices.Add(device);   
    }
    public void Connect(SensorHandler device)
    {
        Detecting += device;
    }

    public void Detect()
    {
        Console.WriteLine("De detector ziet iets");
        Detecting?.Invoke();
        
        foreach (var device in _devices)
        {
            device.Detecting();
        }
    }
}
