// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].

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

int GetCountElements(int[] array)
{
int count = 0;
for (int i = 0; i < array.Length; i++)
{
if(array[i] >= 10 && array[i] <= 99) count++;
}
return count;
}

Console.Write("Введите минимальное значение массива: ");
int minimum = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное значение массива: ");
int maximum= Convert.ToInt32(Console.ReadLine());

int[] arr = CreateArrayRndInt(123, minimum, maximum);
PrintArray(arr);

int result = GetCountElements(arr);
Console.WriteLine($"Количество элементов массива, из отрезка [10,99] = {result}");
