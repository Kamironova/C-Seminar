// Задача: Программа должна показать все целые числа от минуса введеного числа до плюса

Console.Clear();

System.Console.Write("--> ");
int a = Convert.ToInt32(Console.ReadLine());

int i = -1 * a;

while (i <= a)
{
    System.Console.Write(i + " ");
    i++;
};