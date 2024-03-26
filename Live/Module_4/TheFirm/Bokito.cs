using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheFirm;

public class Bokito : IContract
{
    public void Execute()
    {
        Werkt();
    }

    public void Werkt()
    {
       System.Console.WriteLine("Bokito ramt dames in elkaar");
    }
}
