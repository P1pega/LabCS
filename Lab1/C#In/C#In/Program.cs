internal class Program
{
    private static void Main(string[] args)
    {
        double x = 3.981 * 0.01;
        double y = -1.625 * 1000;
        double z = 0.512;
        double e = 2.71828;
        double a =Math.Pow(2, -x) * (Math.Sqrt(x + Math.Pow(Math.Abs(y), 0.25))) * Math.Pow(Math.Pow(e, x -( 1 / Math.Sin(z))), 1.0/3.0);
        Console.WriteLine(a);

    }
}