// Напишите программу которая выводит массив из 8 элементов, заполненный
// нулями и еденицами в случайном порядке. Напр: [0,1,1,0,0,1,0,1]

Console.Clear();

int [] myArray = new int [8];

Random rand = new Random();
    for (int x = 0; x < myArray.Length; x++)
    {
        myArray[x] = rand.Next(2);
        Console.WriteLine(myArray[x]);
    }