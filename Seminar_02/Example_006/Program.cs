Console.Clear();
Random rnd = new Random();

int a = rnd.Next(100, 1000);

Console.WriteLine($"Random Number {a}");

int b = ((a / 100) * 10);


int c = (a % 10);

System.Console.WriteLine(b+c);


