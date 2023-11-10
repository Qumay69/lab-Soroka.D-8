//Уровень Сложный Вариант 4
Console.Write("введите вверхний предел сигмы:");
double num = double.Parse(Console.ReadLine()); 

Console.WriteLine($"|  x  |   f(x)  |");
for ( double x = 1; x <=2.1 ; x += 0.1)
{
    double n = 0;
    for ( double k = 1 ; k <= num; k++)
    {
        double sumF = 1;
        for ( double factorial = 1; factorial <= 3 * k;  factorial++ ) sumF *= factorial;
        n += Math.Pow(-1, 3 * k) * Math.Pow(x, 3 * k) / sumF;
    }
    Console.WriteLine($"|{x,4:F1}{"|",2}{n,8:F2}{"|",2}");
}

