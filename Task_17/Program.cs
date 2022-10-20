// 17. Напишите программу, которая 
// принимает на вход координаты точки (X и Y),
// причём X ≠ 0 и Y ≠ 0 и 
// выдаёт номер четверти плоскости, в которой находится эта точка.

Console. WriteLine("Введите координаты точки");
Console.Write("X: ");
int X = Convert.ToInt32(Console.ReadLine());

Console.Write("Y: ");
int Y = Convert.ToInt32(Console.ReadLine());

int Quater(int XC, int YC)
{
    if (XC > 0 && YC > 0) return 1;
    if (XC < 0 && YC > 0) return 2;
    if (XC < 0 && YC < 0) return 3;
    if (XC > 0 && YC < 0) return 4;
    return 0;
}

int quater = Quater(X, Y);
string resalt = quater > 0 
    ? $"Указанные координаты соответствуют четверти -> {quater}" 
    : "Введены некорректные координаты";

Console.WriteLine(resalt);