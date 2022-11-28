// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29



int AckermannFunction(int numM, int numN)
{
if(numM == 0) return numN + 1;
else if(numM > 0 && numN == 0) return AckermannFunction(numM - 1, 1);
else return AckermannFunction(numM - 1, AckermannFunction(numM, numN - 1));
}

Console.Write("Введите число m: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int numberN = Convert.ToInt32(Console.ReadLine());

while (numberM < 0 || numberN < 0)
{
Console.WriteLine($"Введено отрицательное число");
Console.Write("Введите число m: ");
numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
numberN = Convert.ToInt32(Console.ReadLine());
}

int result = AckermannFunction(numberM, numberN);
Console.WriteLine($"m = {numberM}, n = {numberN} -> A({numberM}, {numberN}) = {result}");