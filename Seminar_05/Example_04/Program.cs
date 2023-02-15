//задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].


Console.Clear(); 
int[] array = new int[123];

Random rnd = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(124);
    System.Console.Write($"[{array[i] + "]"}");
}
System.Console.WriteLine();

int count = 0;

foreach (var item in array)
{
    if (item >= 10 && item <= 99)
    {
        count++;
    }
}
System.Console.WriteLine(count);