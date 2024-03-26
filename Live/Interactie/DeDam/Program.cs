using Belgie;
using Philips;
using Veko;

namespace DeDam;

internal class Program
{
    static void Main(string[] args)
    {
        Lamp lamp = new();
        AK47 gun = new AK47();
        Sensor sensor = new Sensor();

        //sensor.Connect(lamp);
        //sensor.Connect(gun);
        sensor.Connect(lamp.Aan);
        sensor.Connect(gun.Vuur);

        //sensor.Detecting += lamp.Aan;
       // sensor.Detecting += gun.Vuur;

        sensor.Detect();

    }
}
