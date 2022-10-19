// Напишите программу, которая 
// принимает на вход цифру, обозначающую день недели, и 
// проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите номер дня недели от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());

bool Weakend(int num)
{
    if (num == 6 || num == 7) return true;
    return false;
}

if (number > 0 && number < 8)
{
    bool resalt = Weakend(number);
    if (resalt)
    {
        Console.WriteLine("Да. Выходной");
    }
    else
    {
        Console.WriteLine("Нет. Рабочий день");
    }
}
else
{
    Console.WriteLine("Некорректные данные. Введите значение от 1 до 7");
}