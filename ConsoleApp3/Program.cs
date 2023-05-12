Console.Write("Введите радиус окружности:");
double r = double.Parse(Console.ReadLine());
double L = 2 * Math.PI * r;
double S = Math.PI * r * r;
Console.WriteLine($"Длина окружности = {L:F2}");
Console.WriteLine($"Площадь окружности =  {S:F2}");