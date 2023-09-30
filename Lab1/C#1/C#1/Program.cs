
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите радиус");
        double r = Convert.ToInt32(Console.ReadLine());
        double l = 2 * Math.PI * r;
        double S = Math.PI * Math.Pow(r, 2);
        double V = (4 / 3.0) * Math.PI * Math.Pow(r, 3);
        Console.WriteLine($"Окружность: {l}");
        Console.WriteLine($"Площадь: {S}");
        Console.WriteLine($"Объем сферы: {V}");
    }
}