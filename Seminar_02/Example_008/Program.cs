// Написать программу которая будет приниматьна ввод число
// и проверяетт кратно ли оно дновременно 7 и 23

Console.Clear();

System.Console.WriteLine("Enter -->");
double a = Convert.ToDouble(Console.ReadLine());

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
if ((a % 7 == 0) && (a % 23 == 0))
{
    System.Console.WriteLine(a + " кратно одновременно 7 и 23");
}
else
{
    System.Console.WriteLine(a + " не кратно одновременно 7 и 23");
}