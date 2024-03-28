using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagedDude;

public class Unmanaged : IDisposable
{
    private static bool isOpen = false;
    private FileStream? fs;

    public void Open()
    {
        System.Console.WriteLine("Opening...");
        if (!isOpen)
        {
            fs = File.Create("bla.txt");
            System.Console.WriteLine("Geopend");
            isOpen = true;
        }
        else
        {
            System.Console.WriteLine("Helaas al in gebruikt");
        }
    }
    public void Close()
    {
        System.Console.WriteLine("Closing....");

        isOpen = false;
    }

    protected virtual void RuimOp(bool fromDispose)
    {
        Close();
        if (fromDispose)
        {
            fs?.Dispose();
        }
    }
    public void Dispose()
    {
        RuimOp(true);
        GC.SuppressFinalize(this);
    }

    ~Unmanaged()
    {
        RuimOp(false);
    }

}
