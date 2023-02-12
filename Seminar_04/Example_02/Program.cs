// Напишите программу которая принимает на вход число 
// и выдает количество цифр в числе


Console.Clear();

System.Console.Write("--> ");
int a = Convert.ToInt32(Console.ReadLine());
int i = 0;

while (a > 0)
{
    a = a / 10;
    i++;
}
System.Console.WriteLine("Количество символов " + i);

