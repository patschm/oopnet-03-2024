namespace TheFirm;

class Program
{
    static void Main(string[] args)
    {
        Stephan st = new Stephan();
        Teun t = new Teun();
        Mischa m = new Mischa();
        IContract bok = new Bokito();

        ACME firma = new ACME();
        firma.Hire(st);
        firma.Hire(t);
        firma.Hire(m);
        firma.Hire(bok);

        firma.Start();
    }
}
