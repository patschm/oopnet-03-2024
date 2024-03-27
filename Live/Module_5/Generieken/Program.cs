
using System.Runtime.InteropServices;
using System.Text;

namespace Generieken;

class Program
{
    static void Main(string[] args)
    {
        decimal a = 10;
        decimal b = 20;
        Console.WriteLine($"a={a}, b={b}");
        Swap<decimal>(ref a, ref b);
        Console.WriteLine($"a={a}, b={b}");


        Point<int> p1 = new Point<int>{X=10, Y=20};
        System.Console.WriteLine(p1);
        DoeIets(p1);
        System.Console.WriteLine(p1);

        var p2 = Create<Point<long>>();
        p2.X = 30;
        p2.Y = 60;
        System.Console.WriteLine(p2);    
    }

    static T Create<T>() where T: new()
    {
        return new T();
    }

    private static void DoeIets(Point<int> px)
    {
        px.X = 100;
        px.Y = 200;
    }

    static void Swap<T>(ref T x, ref T y) where T: struct
    {
        T tmp = x;
        x = y;
        y = tmp;
    }

//     static void Swap(ref double x, ref double y)
//     {
//         double tmp = x;
//         x = y;
//         y = tmp;
//     }

//     static void Swap(ref float x, ref float y)
//     {
//         float tmp = x;
//         x = y;
//         y = tmp;
//     }
//     static void Swap(ref long x, ref long y)
//     {
//         long tmp = x;
//         x = y;
//         y = tmp;
//     }
    static void Swap(ref int x, ref int y)
    {
        int tmp = x;
        x = y;
        y = tmp;
    }
}
