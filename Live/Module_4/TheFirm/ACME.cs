namespace TheFirm;

public class ACME
{
    private List<IContract> employees = new List<IContract>();

    public void Hire(IContract e)
    {
        employees.Add(e);
    }

    public void Start()
    {
        System.Console.WriteLine("De productiedag bij ACME begint");
        Console.Beep(1000, 1000);
        foreach(var employee in employees)
        {
            employee.Execute();
        }
    }
}
