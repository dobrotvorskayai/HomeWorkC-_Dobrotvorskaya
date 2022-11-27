// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int SumElements(int number)
{
    if (number == 0)
        return 0;
    return number % 10 + SumElements(number / 10);
}

int sumElements = SumElements(num);
Console.WriteLine($"Сумма цифр {sumElements}");
