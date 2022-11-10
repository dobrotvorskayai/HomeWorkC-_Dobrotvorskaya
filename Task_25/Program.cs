// Задача 25: Напишите цикл, который 
// принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите степень: ");
int degree1 = Convert.ToInt32(Console.ReadLine());

int Degree(int number, int degree)
{
    int result = 1;
    for (int i = 1; i <= degree; i++)
    {
       result = result * num;
    }
    return result;
}

if (degree1 > 0)
{
    int res = Degree(num, degree1);
    Console.WriteLine($"Число {num} в степени {degree1} равно {res}");
}
else
{
    Console.WriteLine("Ошибка. Введенное значение степени не является натуральным числом");
}