using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheFirm;

public class Mischa : Employee
{
    public void KanIets()
    {
        System.Console.WriteLine("Mischa speelt met ballen");
    }

    public override void Werkt()
    {
       KanIets();
    }
}
