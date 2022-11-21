// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int ConvertToBin(int num)
{
    int result = 0;
    while (num > 0)
    {
        int dig1 = num % 2;
        result += dig1;
        result *= 10;
        num /= 2;
    }
    return result;
}

int RevertNumber(int par)
{
    int result = 0;
    while (par > 9 || par < 0)
    {
        result += par % 10;
        result *= 10;
        par /= 10;
    }
    result += par % 10;
    return result;
}

Console.WriteLine(RevertNumber(ConvertToBin(number)));

// int d10 = 1; //часть длятого, чтобы 0 не пропадал
// int result = 0;
// int number = 46;
// while (number != 0)
// {
// result = result + number % 2 * d10;
// number = number / 2;
// d10 = d10 * 10;
// }
// Console.WriteLine($"{result}");