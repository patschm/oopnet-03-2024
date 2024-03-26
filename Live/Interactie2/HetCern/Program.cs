namespace HetCern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WillemKlein wk = new();
            SimonVanDeMeer sm = new();

            //wk.Bereken(sm.Subtract, 3, 4);

            MathDel m1 = sm.Add;
            m1 += sm.Add;
            m1 += sm.Subtract;
            m1 += sm.Add;
            m1 += sm.Subtract;
            //m1 = m1 - sm.Subtract;

            foreach(var item in m1.GetInvocationList())
            {
                Console.WriteLine(item.Method.Name);
            }


            int result = m1(1, 2);
            m1.Invoke(2,3); 
            Console.WriteLine(result);

        }
    }
}
