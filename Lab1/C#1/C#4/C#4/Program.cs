internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите трехзначное число: ");
        int a = Convert.ToInt32(Console.ReadLine());
        int dig1 = a / 100;
        int dig2 = a / 10 % 10;
        int dig3 = a % 10;
        int swap = dig3 * 100 + dig2 * 10 + dig1;
        Console.WriteLine("Заменненый номер: " + swap);
    }
}