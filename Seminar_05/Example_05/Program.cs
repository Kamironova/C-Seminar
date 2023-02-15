// найдите произведение пар чисел в одномерном масиве.
//Парой считем первый и последний элемент, второй и предпоследний и т.д. 
// Результат напишите в новом массиве

Console.Clear();

System.Console.WriteLine("-->");
int len = Convert.ToInt32(Console.ReadLine());

int[] array = new int[len];

Random rnd = new Random();
for (int i = 0; i < len; i++)
{
    array[i] = rnd.Next(1,10);
    System.Console.Write($"{array[i]},");
}
System.Console.WriteLine();

for (int i = 0; i < len/2; i++)
{
    System.Console.WriteLine(array[i]*array[len-1-i]);
}
if ((len%2!=0)) System.Console.WriteLine(array[len/2]);