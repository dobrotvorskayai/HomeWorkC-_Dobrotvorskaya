// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.NextDouble()*(max - min) + min;
        array[i] = Math.Round(array[i], 1);
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

double FindMin(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    return min;
}

double FindMax(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    return max;
}

double FindDifference(double[] array)
{
    double maxElement = FindMax(array);
    double minElement = FindMin(array);
    double difference = maxElement - minElement;
    difference = Math.Round(difference, 1);
    return difference;
}

Console.Write("Введите размер массива: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальное значение массива: ");
int minimum = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное значение массива: ");
int maximum= Convert.ToInt32(Console.ReadLine());

double[] arr = CreateArrayRndDouble(sizeArray, minimum, maximum);
PrintArray(arr);

double result = FindDifference(arr);
Console.WriteLine($"Разница между максимальным и минимальным значением = {result}");