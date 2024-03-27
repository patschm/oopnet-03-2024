using Feeds;

class Program
{
    static void Main()
    {
        // foreach (int nr in GetNumbers())
        // {
        //     System.Console.WriteLine($"getal is {nr}");
        // }


        var client = new HttpClient();
        client.BaseAddress = new Uri("https://nu.nl/");
        var result = client.GetAsync("rss").Result;
        if (result.IsSuccessStatusCode)
        {
            var stream = result.Content.ReadAsStream();
            var strategy = new XmlSerializerStrategy();
            //var strategy = new LinqToXmlStrategy();
            //var strategy = new RegexpStrategy();

            foreach (var item in strategy.Process(stream))
            {
             ShowItem(item);
            }
        }
        Console.ReadLine();
    }

    static IEnumerable<int> GetNumbers()
    {
        System.Console.WriteLine("Start");
        yield return 1;
        System.Console.WriteLine("Next");
        yield return 2;
        System.Console.WriteLine("Weer next");
        yield return 3;
    }

    public static void ShowItem(Item item)
    {
        Console.BackgroundColor = ConsoleColor.Yellow;
        Console.WriteLine(item.Category);
        Console.ResetColor();
        Console.BackgroundColor = ConsoleColor.Red;
        Console.WriteLine(item.Title);
        Console.ResetColor();
        Console.WriteLine(item.Description);
        Console.WriteLine();
    }
}

