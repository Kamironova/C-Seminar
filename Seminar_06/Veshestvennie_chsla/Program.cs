// Как сгенерировать вещественные числа, так чтобы они полоучалистб дробными 
// а не целыми

double[] arr = new double[10];

void FillArray(double[] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = genRndDouble(-100, 100, rnd);
    }
}

FillArray(arr);

foreach (var item in arr)
{
    System.Console.WriteLine(item);
}

double genRndDouble(int a, int b, Random rnd)
{
    double rndDouble = a + rnd.NextDouble() * (b - a);
    return rndDouble;
}