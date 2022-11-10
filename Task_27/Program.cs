// Задача 27: Напишите программу, которая 
// принимает на вход число 
// и выдаёт сумму цифр в числе.

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SummDigit(int num)
{
    if (num < 0)
    {
        num = num * -1;
    }
    
    int resalt = num % 10;
    while (num > 10)
    {
    num = num/10;
    resalt = resalt + num % 10;
    }
    return resalt;
}

int summdidgit = SummDigit(number);
Console.WriteLine($"Сумма цифр числа {number} равна {summdidgit}");