// Нипишите программу, которая принимает на вход число "а"
// и выдает сумму чисел от 1 до "а"

Console.Clear();

System.Console.Write("--> ");
int a = Convert.ToInt32(Console.ReadLine());

int sum = 0;

for (int i = 1; i <= a; i++)
{
    sum += i;  // sum = sum + i  - тоже самое
}

System.Console.WriteLine("Sum = " + sum);