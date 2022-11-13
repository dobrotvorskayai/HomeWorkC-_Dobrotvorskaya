// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

// Альтернативный вариант:
// int SumElements(int[] array)
// {
//     int sumElements = 0;
//     for (int i = 1; i < array.Length; i+= 2)
//     {
//         sumElements = sumElements + array[i];
//     }
//     return sumElements;
// }

int SumElements(int[] array)
{
    int sumElements = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1) sumElements = sumElements + array[i];
    }
    return sumElements;
}

Console.Write("Введите размер массива: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальное значение массива: ");
int minimum = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное значение массива: ");
int maximum= Convert.ToInt32(Console.ReadLine());

int[] arr = CreateArrayRndInt(sizeArray, minimum, maximum);
PrintArray(arr);

int result = SumElements(arr);
Console.WriteLine($"Сумма элементов, стоящих на нечетной позиции = {result}");