namespace Geo;

class Program
{
    static void Main(string[] args)
    {
       Point p1 = new Point {X=10, Y=20};
       p1.Show();

       Point p2 = new Point {X=100, Y=200};
       p2.Show();

       Point p3 = p1 + p2;
       p3.Show();

       Point p4 = new Point {X=10, Y=20};
       System.Console.WriteLine(p4 == p1);

    }
}
