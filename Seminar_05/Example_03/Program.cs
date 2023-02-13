// Задайте массив. Напишите программу, которая определяет 
//присутствует ли заданное число в массиве

Console.Clear();

int[] array = new int[5];

Random rnd = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(1, 9);
    System.Console.Write($"[{array[i] + "]"}");
}
System.Console.WriteLine();
System.Console.WriteLine("-->");
int a = Convert.ToInt32(Console.ReadLine());

bool k = false;  // это проверка, можно также было использовать brake

for (int i = 0; i < array.Length; i++)
{
    if (array[i] == a)
    {
        k = true;
    }
    
}

if (k)
{
    System.Console.WriteLine($"Элемент {a} присутствует в массиве");
}
else
{
    Console.WriteLine($"Элемент {a} не присутствует в массиве");
    

}   