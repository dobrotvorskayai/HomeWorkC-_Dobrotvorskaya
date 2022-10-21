// Задача 23
// Напишите программу, которая 
// - принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N.

void CubeTable(int num)
{
    if (num > 0)
    {
        Console.WriteLine($" {"_______"} {"__________"}");
        Console.WriteLine($"|{"Число",6} | {"Куб числа",9}|");
        Console.WriteLine($"|{"_______"}|{"__________"}|");
        for (int i = 1; i <= num; i++)
        {
            Console.WriteLine($"|{i,6} | {i * i * i,9}|");
        }
        Console.WriteLine($"|{"_______"}|{"__________"}|");
    }
    else
    {
        Console.WriteLine("Введите значение больше 0");
    }
}

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
CubeTable(n);

