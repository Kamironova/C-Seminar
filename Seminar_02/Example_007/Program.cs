Console.Clear();

System.Console.WriteLine("Enter number 1 -->");
double a = Convert.ToUInt64(Console.ReadLine());

System.Console.WriteLine("Enter number 2 -->");
double b = Convert.ToInt64(Console.ReadLine());

if (a % b == 0)
{
    System.Console.WriteLine($"{a} кратно {b}");
}

else 
{
    double c = (a % b) % 10;
    System.Console.WriteLine($"Не кратно, остаток от деления равен {c}");
}