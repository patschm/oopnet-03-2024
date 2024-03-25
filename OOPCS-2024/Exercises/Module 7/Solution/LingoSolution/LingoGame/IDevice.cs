namespace LingoGame
{
    // TODO 0: Not it's time to make the game device independent. 
    // The current version only works for console application but we want to make
    // the game available for any device.
    // The problem, however, is that we don't know what device and how to draw on the specific device
    // Fortunately we have interface. 

    // TODO 1: Define an interface IDevice with 3 methods. All methods must return void and accept
    // an argument of type char
    // 1) DrawDefault
    // 2) DrawPartial
    // 3) DrawExact
    public interface IDevice
    {
        void DrawDefault(char c);
        void DrawPartial(char c);
        void DrawExact(char c);
    }
}
