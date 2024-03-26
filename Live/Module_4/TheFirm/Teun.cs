using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace TheFirm;

public class Teun : Employee
{
    public void VoertUit()
    {
        System.Console.WriteLine("Teun is aanwezig (tot 5 uur)");
    }

    public override void Werkt()
    {
       VoertUit();
    }
}
