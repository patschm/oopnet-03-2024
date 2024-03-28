using System.Diagnostics;
using System.Text;

namespace Vullis;

internal class Program
{
    static void Main(string[] args)
    {
        //string s = "";
        StringBuilder s = new StringBuilder();
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        for(int i = 0; i <100_000; i++)
        {
            //s += i.ToString();
            s.Append(i.ToString());
        }
        stopwatch.Stop();
        Console.WriteLine(stopwatch.Elapsed);
    }
}
