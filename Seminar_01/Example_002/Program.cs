Console.Clear();
Console.WriteLine($"Первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Второе число: ");

int b = Convert.ToInt32(Console.ReadLine());

if (a == (b * b))
{
    Console.WriteLine($"УраУра!{a} квадрат {b}");
}
else
{
    Console.WriteLine("Не квадрат!");
}