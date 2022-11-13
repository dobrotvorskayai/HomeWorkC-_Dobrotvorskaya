// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

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

int[] MultiplicationNumbers(int[] array)
{
    int sizeNewArray = array.Length / 2;
    if (array.Length % 2 == 1) sizeNewArray = sizeNewArray + 1;
    int[] newArray = new int[sizeNewArray];
    for (int i = 0; i < array.Length / 2; i++)
    {
        newArray[i] = array[i] * array[array.Length - 1 - i];
    }
    if (array.Length % 2 == 1) newArray[newArray.Length - 1] = array[array.Length / 2];
    return newArray;
}

Console.Write("Введите размер массива: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальное значение массива: ");
int minimum = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное значение массива: ");
int maximum= Convert.ToInt32(Console.ReadLine());

int[] arr = CreateArrayRndInt(sizeArray, minimum, maximum);
PrintArray(arr);

int[] result = MultiplicationNumbers(arr);
PrintArray(result);