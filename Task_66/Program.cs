// Задача 66: Задайте значения M и N.
// Напишите программу, которая найдёт сумму натуральных элементов
// в промежутке от M до N. Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int SumNaturalNumbers(int m, int n)
{
    if (m == n + 1)
        return 0;
    return m + SumNaturalNumbers(m + 1, n);
}

Console.WriteLine("Введите два числа: ");
int first = Convert.ToInt32(Console.ReadLine());
int second = Convert.ToInt32(Console.ReadLine());

if (first > second)
{
    int temp = second;
    second = first;
    first = temp;
}

int resalt = SumNaturalNumbers(first, second);
Console.WriteLine($"Сумма чисел равна {resalt}");
