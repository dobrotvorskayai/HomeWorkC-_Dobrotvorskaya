// Задача 21
// Напишите программу, которая 
// - принимает на вход координаты двух точек и 
// - находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double Dest(double XC1, double XC2, double YC1, double YC2, double ZC1, double ZC2)
{
    double kat1 = XC1 - XC2;
    double kat2 = YC1 - YC2;
    double kat3 = ZC1 - ZC2;
    double gip2 = kat1 * kat1 + kat2 * kat2 + kat3 * kat3;
    double gip = Math.Sqrt(gip2);
    double res = Math.Round(gip, 2, MidpointRounding.ToZero);
    return res;
}

Console.WriteLine("Введите координату Х точки А: ");
double X1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Y точки А: ");
double Y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Z точки А: ");
double Z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Х точки B: ");
double X2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Y точки B: ");
double Y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Z точки B: ");
double Z2 = Convert.ToDouble(Console.ReadLine());


double resalt = Dest(X1, X2, Y1, Y2, Z1, Z2);
Console.WriteLine($"Расстояние между точками А ({X1}, {Y1}, {Z1}) и В ({X2}, {Y2}, {Z2}) равно {resalt}");