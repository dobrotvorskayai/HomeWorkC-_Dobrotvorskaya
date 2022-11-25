// Задача 60. Сформируйте трёхмерный массив
// из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив,
// добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

int[,,] CreateMatrixRndInt(int first, int second, int third)
{
    int[,,] matrix3D = new int[first, second, third];
    int elem = 10;
    for (int i = 0; i < matrix3D.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3D.GetLength(1); j++)
        {
            for (int k = 0; k < matrix3D.GetLength(2); k++)
            {
                matrix3D[i, j, k] = elem++;
            }
        }
    }
    return matrix3D;
}

void PrintMatrix3D(int[,,] matrix3D)
{
    for (int i = 0; i < matrix3D.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3D.GetLength(1); j++)
        {
            for (int k = 0; k < matrix3D.GetLength(2); k++)
            {
                Console.Write($"{matrix3D[i, j, k]} {(i, j, k)}   ");
            }
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите первый размер массива: ");
int sizeA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второй размер массива: ");
int sizeB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третий размер массива: ");
int sizeC = Convert.ToInt32(Console.ReadLine());

if (sizeA * sizeB * sizeC > 90)
    Console.WriteLine(
        "Ошибка. Невозможно вывести массив такого размера с неповторяющимися двузначными числами."
    );
else
{
    int[,,] array3D = CreateMatrixRndInt(sizeA, sizeB, sizeC);
    PrintMatrix3D(array3D);
}
