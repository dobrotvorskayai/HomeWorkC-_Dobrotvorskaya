// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
    Console.Write($"Введите {i+1} число: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void PrintArray (int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
    if(i < array.Length - 1) Console.Write($"{array[i]},");
    else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int SumElements(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) sum += 1;
    }
    return sum;
}

Console.Write("Введите количество чисел: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());

int[] arr = CreateArray(sizeArray);
PrintArray(arr);

int resalt = SumElements(arr);
Console.Write($"Количество чисел > 0: {resalt}");