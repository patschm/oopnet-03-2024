using LingoGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLingo
{
    public class ConsoleDevice : IDevice
    {
        public void DrawDefault(char c)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(c);
            Console.ResetColor();
        }

        public void DrawPartial(char c)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(c);
            Console.ResetColor();
        }

        public void DrawExact(char c)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(c);
            Console.ResetColor();
        }
    }
}
