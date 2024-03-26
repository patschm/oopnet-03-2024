using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheFirm;

public abstract class Employee : Person, IContract
{
    public void Execute()
    {
       Werkt();
    }

    public abstract void Werkt();
}

public class Person
{
}