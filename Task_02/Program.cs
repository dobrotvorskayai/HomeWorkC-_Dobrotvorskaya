// Напишите программу, которая на вход принимает два числа и выдает, 
// какое число болшее, а какое меньшее.

Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 != number2)
{
    if (number1 > number2)
    {
        Console.WriteLine($"Число {number1} большее, а число {number2} меньшее");
    }
    else
    {
        Console.WriteLine($"Число {number2} большее, а число {number1} меньшее");
    }
}
else Console.WriteLine($"Нет наибольшего и наименьшего, т.к. число {number2} равно числу {number1}");