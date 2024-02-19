using Formula_de_la_dencidad_de_un_objeto;
internal class Progrma
{
    public static void Main(string[] arg)
    {
        Mass m = new Mass();
        Console.WriteLine("What is the mass? ");
        m.M = Convert.ToDouble(Console.ReadLine());

        volume v = new volume();
        Console.WriteLine("What is the volume ");
        v.V = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine(m.ToString() + v.ToString() + " Density: " + m.M / v.V);
    }
}