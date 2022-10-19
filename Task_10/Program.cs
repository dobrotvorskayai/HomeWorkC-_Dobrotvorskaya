// Задача 10: Напишите программу, которая 
// принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Напишите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int Res(int num)
{
    int res = num % 100 / 10;
    return res;
}

if (number > 99 && number < 1000)
{
    int resalt = Res(number);
    Console.WriteLine($"Вторая цифра числа {number} равна {resalt}");
}
else Console.WriteLine($"Число {number} не трёхзначное");