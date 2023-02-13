// Задайте массив из 12 элементов, заполненный случайными числами
// из промежутка [-9,9]. Найдите сумму отрицательных и положительных
// элементов массива.
// Например: в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных 
// чисел равна 29Б сумма отрицательных -20

Console.Clear();

int[] arr = new int[12];
int sum1 = 0;
int sum2 = 0;

Random rnd = new Random();
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(-9, 9);
}

foreach (var item in arr)
{
    System.Console.Write($"[{item + "]"}");
}

foreach (var item in arr)
{
    if (item < 0)
    {
        sum1 += item;
    }
    else sum2 += item;
}

System.Console.WriteLine($"\nСумма отрицательных = {sum1}");
System.Console.WriteLine($"Сумма положительных = {sum2}");