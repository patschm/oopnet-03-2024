namespace ManagedDude;

class Program
{
    static Unmanaged m1 = new Unmanaged();
    static Unmanaged m2 = new Unmanaged();

    static void Main(string[] args)
    {
        using(m1)
        {
            m1.Open();
        }

        try
        {
            m2.Open();
        }
        finally
        {
            m2.Dispose();
        }
        m1 = null;
        m2 = null;
         GC.Collect();
        GC.WaitForPendingFinalizers();

        using (Unmanaged m3 = new Unmanaged())
        {
            m3.Open();
        }

     // m1.Close();
        GC.Collect();
        GC.WaitForPendingFinalizers();
        
    }
}
