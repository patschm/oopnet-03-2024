



using System.Collections.Concurrent;

namespace Draadjes;

class Program
{
    static void Main(string[] args)
    {
        //WhatHappened();
        //OuweNietMeerWerkendeMeuk();
        //EnDanNuInParallel();
        //WordtVervolgt();
        //FoutenAfhandeling();
        //HetWordtLeuker();
        //FoutenAfhandelingDeel2();
        //ToeterEnBel1();
        //LampjesKijken();
        //Corruptie();
        //Garage();
        Collecties();
        Console.WriteLine("Eind programma");
        Console.ReadLine();
    }

    private static void Collecties()
    {
        ConcurrentBag<int> list = new ConcurrentBag<int>();
        list.Add(2);

        foreach(int x in list)
        {
            System.Console.WriteLine(x);
        }
    }

    static Random rdn = new Random();
    private static void Garage()
    {
        SemaphoreSlim slagboom = new SemaphoreSlim(20, 20);

        Parallel.For(0, 100, kenteken =>
        {
            Console.WriteLine($"Auto ({kenteken}) komt aan bij de garage");
            slagboom.Wait();
            Console.WriteLine($"**** Auto ({kenteken}) rijdt de garage in.");
            Task.Delay(4000 + rdn.Next(1000, 6000)).Wait();
            slagboom.Release();
            Console.WriteLine($"xxxx Auto ({kenteken}) rijdt de garage uit.");
        });
    }

    static object stokje = new object();
    private static void Corruptie()
    {
        int teller = 0;

        Parallel.For(0, 10, id =>
        {
            //Monitor.Enter(stokje);
            //Monitor.Exit(stokje);
            lock (stokje)
            {
                int tmp = teller;
                Task.Delay(1000).Wait();
                System.Console.WriteLine($"Taak {id}");
                if (teller == 5) return;
                tmp++;
                teller = tmp;
            }
        });

        System.Console.WriteLine(teller);
    }

    private static void OuweNietMeerWerkendeMeuk()
    {
        // You're screwed
        Func<int, int, int> f1 = LongAdd;
        IAsyncResult ar = f1.BeginInvoke(3, 4, ar =>
        {
            int result = f1.EndInvoke(ar);
            System.Console.WriteLine(result);
        }, null);
    }

    private static async void LampjesKijken()
    {
        int a = 0;
        int b = 0;

        var zaklamp1 = new AutoResetEvent(false);
        var zaklamp2 = new AutoResetEvent(false);

        var t1 = Task.Run(() =>
        {
            Task.Delay(1000).Wait();
            a = 26;
            // Iedere thraed heeft al een zaklamp
            //zaklamp1.Set();
        });
        var t2 = Task.Run(() =>
        {
            Task.Delay(2000).Wait();
            b = 26;
            //zaklamp2.Set();
        });

        await Task.WhenAll(t1, t2);
        //WaitHandle.WaitAny([zaklamp1, zaklamp2]);
        int result = a + b;
        System.Console.WriteLine(result);
    }

    private static void ToeterEnBel1()
    {
        CancellationTokenSource nikko = new CancellationTokenSource();
        CancellationToken bommetje = nikko.Token;

        Task.Run(() =>
        {
            do
            {
                Console.Write(".");
                Task.Delay(200).Wait();
                //bommetje.ThrowIfCancellationRequested();
                if (bommetje.IsCancellationRequested)
                {
                    System.Console.WriteLine();
                    return;
                }
            }
            while (true);
        });


        System.Console.WriteLine("Press enter to stop");
        Console.ReadLine();
        nikko.Cancel();
    }

    private static async void FoutenAfhandelingDeel2()
    {
        try
        {
            await Task.Run(() =>
            {
                System.Console.WriteLine("We gaan beginnen....");
                Task.Delay(1000).Wait();
                throw new Exception("ooops");
            });
        }
        catch (Exception e)
        {
            System.Console.WriteLine(e.Message);
        }
    }

    private static async void HetWordtLeuker()
    {
        int x = 10;
        string y = "hoi";
        Task<int> t1 = Task.Run(() => LongAdd(4, 5));
        int result = await t1;
        System.Console.WriteLine(result);
        System.Console.WriteLine("En we gaan verder. Deel 1");
        result = await Task.Run(() => LongAdd(6, 7));
        System.Console.WriteLine(result);
        System.Console.WriteLine("En we gaan verder. Deel 2");
        result = await Task.Run(() => LongAdd(7, 8));
        System.Console.WriteLine(result);
        System.Console.WriteLine("En we gaan verder. Deel 3");
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
        }).ContinueWith(pt =>
        {
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
