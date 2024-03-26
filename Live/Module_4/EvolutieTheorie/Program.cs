namespace EvolutieTheorie;

delegate int MathDel(int a, int b);

class Program
{
    static bool NameStartsWithX(Person p)
    {
        return p.Name.StartsWith("X");
    }
    static bool NameStartsWithF(Person p)
    {
        return p.Name.StartsWith("F");
    } 
    static void Main(string[] args)
    {
        List<Person> people = new List<Person>();
        people.Add(new Person {Name = "ZZZZ", Age = 17});
         people.Add(new Person {Name = "XXXX", Age = 57});
       people.Add(new Person {Name = "DDDD", Age = 98});
         people.Add(new Person {Name = "FFFF", Age = 27});
         string n = "D";

        var res = people.Where(p=>p.Name.StartsWith(n));
        foreach(var p in res)
        {
            System.Console.WriteLine(p.Name);
        }


        // 2002. Framework 1.0/1.1
        MathDel m1 = new MathDel(Add);
        int result = m1(1,2);

        // 2005. Framework 2.0
        MathDel m2 = Add;
        result = m2(2,3);

        int c = 100;

        MathDel m3 = delegate(int a, int b)
            {
                return a+b+c;
            };

        result = m3(3,4);

        // 2008. Framework 3.0/3.5
        MathDel m4 = (a, b) => a+b+c;

        result = m4(3,4);

        // procedures
        Action x1 = () => System.Console.WriteLine("Hoi");
        
        Action<string> a = System.Console.WriteLine;
        a("ha");

        // functions 
        Func<int, int, int> f1 = Add;

        result = f1(7,8);


        System.Console.WriteLine(result);

         bool NameStartsWithFF(Person p)
        {
             return p.Name.StartsWith(n);
        } 
    }

    static int Add(int a, int b)
    {
        return a+b;
    }
}

public class Person
{
    public string? Name { get; set; }
    public int Age { get; set; }

    public override string ToString() =>  $"{Name} {Age}";
    // {
    //     return $"Name} {Age}";
    // }

}