// Напишите программуб которая на вход принимает 2 числа и проверяет
// является ли одно квадратом другого


int Number()
{
    System.Console.Write("Enter --> ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int a = Number();
int b = Number();

if (a * a == b || b * b == a)
{
    System.Console.WriteLine(a + " является квадратом " + b);
}

else
{
    System.Console.WriteLine(a + " не является квадратом " + b);

}