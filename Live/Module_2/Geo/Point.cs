
namespace Geo;

public class Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public static Point operator+(Point a, Point b)
    {
        return new Point {
            X=a.X + b.X, 
            Y=a.Y + b.Y
            };
    }

    public static bool operator==(Point a, Point b)
    {
        return a.X == b.X && a.Y == b.Y;
    } 
     public static bool operator!=(Point a, Point b)
    {
        return !(a ==  b);
    } 

    public void Show()
    {
        Console.WriteLine($"({X}, {Y})");
    }
}
