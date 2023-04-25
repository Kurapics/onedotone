Console.Write("Введите x: ");
double x = double.Parse(Console.ReadLine());
Console.WriteLine("Ответ: " + (Math.Pow(Math.E, x) - x - 2 + Math.Pow((1 + x), x)));