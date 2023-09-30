internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите трезначное число");
        int a = Convert.ToInt32(Console.ReadLine());
        int sum = a / 100 + (a % 100) / 10 + a % 10;
        int product = (a / 100) * ((a % 100) / 10) * (a % 10);
        Console.WriteLine($"Сумма цифр: {sum}");
        Console.WriteLine($"Произведение цифр: {product}");

    }
}