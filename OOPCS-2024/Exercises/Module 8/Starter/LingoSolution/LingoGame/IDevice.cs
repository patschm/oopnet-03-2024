namespace LingoGame
{
    public interface IDevice
    {
        void DrawDefault(char c);
        void DrawPartial(char c);
        void DrawExact(char c);
    }
}
