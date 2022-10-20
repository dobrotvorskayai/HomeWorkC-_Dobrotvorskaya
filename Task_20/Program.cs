// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координату Х точки А: ");
int X1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y точки А: ");
int Y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Х точки B: ");
int X2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y точки B: ");
int Y2 = Convert.ToInt32(Console.ReadLine());

double Dest(double XC1, double XC2, double YC1, double YC2)
{
    double kat1 = XC1 - XC2;
    double kat2 = YC1 - YC2;
    double gip2 = kat1 * kat1 + kat2 * kat2;
    double gip = Math.Sqrt(gip2);
    double res = Math.Round(gip, 2, MidpointRounding.ToZero);
    return res;
}

double resalt = Dest(X1, Y1, X2, Y2);
Console.WriteLine($"Расстояние между точками А ({X1}, {Y1}) и В ({X2}, {Y2}) равно {resalt}");



