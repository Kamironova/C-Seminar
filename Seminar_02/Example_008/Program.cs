// Написать программу которая будет приниматьна ввод число
// и проверяетт кратно ли оно дновременно 7 и 23

Console.Clear();

// Функция запрашивающая число на ввод от пользователя:

double Number()
{
    System.Console.WriteLine("-->");
    double number = Convert.ToDouble(Console.ReadLine());
    return number;
}





//System.Console.WriteLine("Enter -->");
//double a = Convert.ToDouble(Console.ReadLine());

// if (a % 7 == 0)
// {
//     if (a % 23 == 0)
//     {
//         System.Console.WriteLine(a + " кратно одновременно 7 и 23");
//     }
//     else
//     {
//         System.Console.WriteLine(a + " не кратно одновременно 7 и 23");
//     }
// }
// else
// {
//     System.Console.WriteLine(a + " не кратно одновременно 7 и 23");
// }

double num = Number();

if ((num % 7 == 0) && (num % 23 == 0))
{
    System.Console.WriteLine(num + " кратно одновременно 7 и 23");
}
else
{
    System.Console.WriteLine(num + " не кратно одновременно 7 и 23");
}