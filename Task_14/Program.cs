// 14. Напишите программу, которая
// принимает на вход число и 
// проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int number1 = 7;
int number2 = 23;

bool DivNum (int num, int num1, int num2)
{
    int result1 = num%num1;
    int result2 = num%num2;
    if (result1 ==0 && result2 ==0) return true;
    return false;
}

bool resalt = DivNum (number, number1, number2);
if (resalt)
{
    Console.Write("Кратно");
}
else
{
    Console.Write("Не кратно");
}
