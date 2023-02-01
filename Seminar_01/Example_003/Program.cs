Console.Clear();

//Первый вариант

// Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());

// switch (a)  
// {
//     case 1:
//     Console.WriteLine("Понедельник");
//     break;

//     case 2:
//     Console.WriteLine("Вторник");
//     break;

//     case 3:
//     Console.WriteLine("Среда");
//     break;

//     case 4:
//     Console.WriteLine("Четверг");
//     break;

//     case 5:
//     Console.WriteLine("Пятница");
//     break;

//     case 6:
//     Console.WriteLine("Суббота");
//     break;

//     case 7:
//     Console.WriteLine("Воскресенье");
//     break;

//     default :
//     Console.WriteLine("Введите число 1-7");
//     break;
// }

//Второй вариант с If/else
Console.WriteLine("Введите число от 1 до 7");

int a = Convert.ToInt32(Console.ReadLine());

if (a == 1)
{
    Console.Write("Понедельник");
}

else if (a == 2)
{
    Console.Write("Вторник");
}

else if (a == 3)
{
    Console.Write("Среда");
}

else if (a == 4)
{
    Console.Write("Четверг");
}

else if (a == 5)
{
    Console.Write("Пятница");
}

else if (a == 6)
{
    Console.Write("Суббота");
}

else if (a == 7)
{
    Console.Write("Воскресенье");
}

else
{
    Console.Write("Некорректный ввод. Введите число от 1 до 7");
}
