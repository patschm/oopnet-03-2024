
using System.IO.Compression;
using System.Text;
using System.Xml.Serialization;

namespace StromingsLeer;

class Program
{
    static void Main(string[] args)
    {
        // int? age = null;
        // Nullable<int> age2 = null;
        // int final = age2 ?? 10;

        //SchrijvenAlsNeanderthalers();
        //LezenAlsNeanderthalers();
        //SchrijvenAlsHomoSapiens();
        //LezenAlsHomoSapiens();
        //SchrijvenAlsZip();
        //LezenAlsZip();
        //SerializePeople();
       // DeserializePeople();
    }

    private static void DeserializePeople()
    {
        XmlSerializer ser = new XmlSerializer(typeof(List<Person>));
        FileStream fs = File.OpenRead(@"E:\people.xml");
        var list = ser.Deserialize(fs) as List<Person>;
        fs.Close();

        foreach(var p in list!)
        {
            System.Console.WriteLine(p);
        }
    }

    private static void SerializePeople()
    {
        var list  = new Bogus.Faker<Person>()
            .RuleFor(p=>p.FirstName, f=>f.Person.FirstName)
            .RuleFor(p=>p.LastName, f=>f.Person.LastName)
            .RuleFor(p=>p.Age, f => f.Random.Int(0, 123))
            .Generate(100)
            .ToList();

        XmlSerializer ser = new XmlSerializer(typeof(List<Person>));
        FileStream fs = File.Create(@"E:\people.xml");
        ser.Serialize(fs, list);
        fs.Close();

        // foreach(var p in list)
        // {
        //     System.Console.WriteLine(p);
        // }
    }

    private static void LezenAlsZip()
    {
        FileStream fs = File.OpenRead(@"E:\data2.zip");
        GZipStream zip = new GZipStream(fs, CompressionMode.Decompress);
        StreamReader reader = new StreamReader(zip);

        string? line;
        while ((line = reader.ReadLine()) != null)
        {
            Console.WriteLine(line);
        }

        fs.Close();
    }
 private static void SchrijvenAlsZip()
    {
        FileStream fs = File.Create(@"E:\data2.zip");
        GZipStream zip = new GZipStream(fs, CompressionMode.Compress);
        StreamWriter writer = new StreamWriter(zip);

        for (int i = 0; i < 1000; i++)
        {
            writer.WriteLine($"Hello World {i}");
        }
        writer.Flush();
        fs.Close();
    }
    private static void LezenAlsHomoSapiens()
    {
        FileStream fs = File.OpenRead(@"E:\data2.txt");
        StreamReader reader = new StreamReader(fs);

        string? line;
        while ((line = reader.ReadLine()) != null)
        {
            Console.WriteLine(line);
        }

        fs.Close();
    }

    private static void SchrijvenAlsHomoSapiens()
    {
        FileStream fs = File.Create(@"E:\data2.txt");
        StreamWriter writer = new StreamWriter(fs);

        for (int i = 0; i < 1000; i++)
        {
            writer.WriteLine($"Hello World {i}");
        }
        writer.Flush();
        fs.Close();
    }

    private static void LezenAlsNeanderthalers()
    {
        FileStream fs = File.OpenRead(@"E:\data.txt");
        byte[] buffer = new byte[8];
        int nrRead = 0;
        while ((nrRead = fs.Read(buffer)) > 0)
        {
            string s = Encoding.UTF8.GetString(buffer);
            System.Console.Write(s);
            Array.Clear(buffer, 0, buffer.Length);
        }
    }

    private static void SchrijvenAlsNeanderthalers()
    {
        string s = "Hello World";
        FileStream fs;
        if (!File.Exists(@"E:\data.txt"))
        {
            fs = File.Create(@"E:\data.txt");
        }
        else
        {
            fs = File.OpenWrite(@"E:\data.txt");
        }

        for (int i = 0; i < 1000; i++)
        {
            byte[] data = Encoding.UTF8.GetBytes($"{s} {i}\r\n");
            fs.Write(data);
        }
        fs.Close();
    }
}
