// Напишите программу, которая принимает на вход число N
// и выдает произведение чисел от 1 до N

Console.Clear();

System.Console.Write("--> ");
int a = Convert.ToInt32(Console.ReadLine());

int f = 1;

for (int i = 1; i <= a; i++)
{
    f = f * i;
}

System.Console.WriteLine("Произведение из {a} -> " +f);