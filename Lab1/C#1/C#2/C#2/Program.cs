private static void Main(string[] args)
{
    int a = Convert.ToInt32(Console.ReadLine());
    int b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Перед заменой:");
    Console.WriteLine("a=" + a);
    Console.WriteLine("b=" + b);
    int temp = a;
    a = b;
    b = temp;
    Console.WriteLine("После замены:");
    Console.WriteLine("a=" + a);
    Console.WriteLine("b=" + b);

}
}