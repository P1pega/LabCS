internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите длину катетов: ");
        double a = Convert.ToInt32(Console.ReadLine());
        double b = Convert.ToInt32(Console.ReadLine());
        double P = ((Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2))) + (a + b));
        double S = (a * b / 2);
        Console.WriteLine($"Периметр: {P}");
        Console.WriteLine($"Площадь: {S}");
    }
}