// Задача 19
// Напишите программу, которая 
// - принимает на вход пятизначное число и 
// - проверяет, является ли оно палиндромом.
// - Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

bool Palindrome(int num)
{
    int n1 = num / 10000;
    int n2 = num / 1000 % 10;
    int n4 = num / 10 % 10;
    int n5 = num % 10 ;
    return n1 == n5 && n2 == n4 ? true : false;
}

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 9999 && number < 100000)
{
    bool resalt = Palindrome(number);
    if (resalt) Console.WriteLine($"Да. Число {number} является палиндромом");
    else Console.WriteLine($"Нет. Число {number} НЕ является палиндромом");
}
else
{
    Console.WriteLine("Ошибка данных. Введите пятизначное число");
}