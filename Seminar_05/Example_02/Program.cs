// Напишите программу замены элементов массива: положительные занените
// на сооиветствующие отрицательные, и наоборот
// Например: [-4,-8,8,2] -> [4,8,-8,-2]

Console.Clear();

int[] array = new int[4];

Random rnd = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(-9, 10);
    System.Console.Write($"[{array[i] + "]"}");
}
System.Console.WriteLine();
for (int i = 0; i < array.Length; i++)
{
    array[i] = array[i] * -1;
    System.Console.Write($"[{array[i] + "]"}");
}
System.Console.WriteLine();