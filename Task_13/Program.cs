// Задача 13: Напишите программу, которая 
// выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int ThirdDigit(int num)
{
    while (num > 1000 || num < -1000)
    {
    num = num / 10;
    }
    int res = num % 10;
    if (res < 0) res = res * -1;
    return res;
}

if ((number < 100 && number > 0) || (number > -100 && number <= 0)) Console.WriteLine($"Третьей цифры нет");

else
{
    int resalt = ThirdDigit(number);
    Console.WriteLine($"Третья цифра заданного числа равна {resalt}");
}