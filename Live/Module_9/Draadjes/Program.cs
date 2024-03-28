



namespace Draadjes;

class Program
{
    static void Main(string[] args)
    {
        //WhatHappened();
        //EnDanNuInParallel();
        //WordtVervolgt();
        FoutenAfhandeling();
        Console.WriteLine("Eind programma");
        Console.ReadLine();
    }

    private static void FoutenAfhandeling()
    {
        // try
        // {
        //     Task.Run(() =>
        //     {
        //         System.Console.WriteLine("We gaan beginnen....");
        //         Task.Delay(1000).Wait();
        //         throw new Exception("ooops");
        //     });
        // }
        // catch (Exception e)
        // {
        //     System.Console.WriteLine(e.Message);
        // }
        Task.Run(() =>
        {
            System.Console.WriteLine("We gaan beginnen....");
            Task.Delay(1000).Wait();
            throw new Exception("ooops");
        }).ContinueWith(pt=>{
            if (pt.Exception != null)
            {
                System.Console.WriteLine(pt.Exception.InnerException?.Message);
            }
        });
    }

    private static void WordtVervolgt()
    {
        Task<int> t1 = new Task<int>(() =>
        {
            int result = LongAdd(1, 2);
            return result;
        });

        t1.ContinueWith(pt =>
        {
            int result = pt.Result;
            Console.WriteLine($"Het rsultaat is : {result}");
        });

        t1.ContinueWith(pt => System.Console.WriteLine("Tweede taak"));

        t1.Start();
    }

    private static void EnDanNuInParallel()
    {
        Task<int> t1 = new Task<int>(() =>
        {
            int result = LongAdd(1, 2);
            return result;
        });

        t1.Start();
        do
        {
            System.Console.Write(".");
            Task.Delay(500).Wait();
        }
        while (!t1.IsCompleted);
        System.Console.WriteLine();
        int res = t1.Result;
        Console.WriteLine($"Het rsultaat is : {res}");
    }

    private static void WhatHappened()
    {
        int result = LongAdd(1, 2);
        Console.WriteLine($"Het rsultaat is : {result}");
    }

    static int LongAdd(int a, int b)
    {
        Task.Delay(10000).Wait();
        return a + b;
    }
}
