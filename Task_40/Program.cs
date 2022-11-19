// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

Console.WriteLine("Введите три числа через Enter: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int num3 = Convert.ToInt32(Console.ReadLine());

bool IsExsistTriangle (int number1, int number2, int number3)
{
    return number1 < number2 + number3 && number2 < number1 + number3 && number3 < number1 + number2;
}

bool isExsistTriangle = IsExsistTriangle(num1, num2, num3);
Console.WriteLine(isExsistTriangle);
