// Задача 28: Напишите программу, которая
// принимает на вход число N
// и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int Fact(int number)
{
    int fact = 1;
    for (int i = 1; i <= number; i++)
    {
        // sum = sum + i;
        fact *= i;
    }
    return fact;
}

if (num > 0)
{
    int multiply = Fact(num);
    Console.WriteLine($"Произведение чисел от 1 до {num} равна {multiply}");
}
else
{
    Console.WriteLine("Ведите целое положительное число");
}
