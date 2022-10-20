// Задача 18: Напишите программу, которая 
// по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти: ");
int quater = Convert.ToInt32(Console.ReadLine());

string Diopos(int quat)
{
    if (quat == 1) return "диапазон значений коодинат X > 0 и Y > 0";
    if (quat == 2) return "диапазон значений коодинат X < 0 и Y > 0";
    if (quat == 3) return "диапазон значений коодинат X < 0 и Y < 0";
    if (quat == 4) return "диапазон значений коодинат X > 0 и Y < 0";
    return "Ошибка. Введите значение от 1 до 4";
}

string resalt = Diopos(quater);
Console.Write($"Четверти {quater} соответствует: ");
Console.WriteLine(resalt);