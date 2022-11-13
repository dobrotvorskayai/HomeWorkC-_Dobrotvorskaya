// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

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

bool FindDidgit(int didgit, int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == didgit) return true;
    }
    return false;
}

Console.Write("Введите размер массива: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальное значение массива: ");
int minimum = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное значение массива: ");
int maximum= Convert.ToInt32(Console.ReadLine());

int[] arr = CreateArrayRndInt(sizeArray, minimum, maximum);
PrintArray(arr);

Console.Write("Введите искомое число: ");
int findDidgit = Convert.ToInt32(Console.ReadLine());

// bool find = FindDidgit (findDidgit, arr);
Console.WriteLine(FindDidgit(findDidgit, arr)? "Да" : "нет");
// if (find)
// {
//     Console.Write($"Число {findDidgit} присутствует в массиве");
// }
// else
// {
//     Console.Write($"Число {findDidgit} отсутствует в массиве");
// }