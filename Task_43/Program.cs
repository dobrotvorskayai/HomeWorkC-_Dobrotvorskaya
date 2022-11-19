// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введите значение числа b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите значение числа k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите значение числа b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите значение числа k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

double[] FindPoint(double d1, double l1, double d2, double l2)
{
    double[] coordinates = new double [2];
    coordinates[0] = (d2 - d1)/(l1 - l2);
    coordinates[1] = l1*coordinates[0] + d1;
    return coordinates;
}

void PrintArray (double[] array)
{
    Console.Write("(");
    for (int i = 0; i < array.Length; i++)
    {
    if(i < array.Length - 1) Console.Write($"{array[i]}; ");
    else Console.Write($"{array[i]}");
    }
    Console.WriteLine(")");
}

double[] resalt = FindPoint(b1, k1, b2, k2);
Console.Write($"Координаты точки = ");
PrintArray(resalt);