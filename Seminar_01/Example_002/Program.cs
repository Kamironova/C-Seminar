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



// Второй вариант

// Console.WriteLine("Enter first nuber: ");
// string? str = Console.ReadLine();
// int firstNumber = int.Parse(str);

// Console.WriteLine("Enter second nuber: ");
// str = Console.ReadLine();
// int secondNumber = int.Parse(str);

// if ((Math.Pow(secondNumber, 2)) == firstNumber)  // эта команда возводит в квадрат
// {
//     Console.WriteLine("Второе число является квадратом первого");
// }
// else
// { 
//     Console.WriteLine("Второе число не является квадратом первого");
//}