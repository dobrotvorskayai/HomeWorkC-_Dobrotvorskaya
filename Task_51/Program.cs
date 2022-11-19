// Задача 51: Задайте двумерный массив.
// Найдите сумму элементов, находящихся на главной диагонали
// (с индексами (0,0); (1;1) и т.д.)

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++) // Проход по строкам. Чтобы сделать по столбцам, сначала идем по j, потом по i
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1)
                Console.Write($"{matrix[i, j], 5} | ");
            else
                Console.Write($"{matrix[i, j], 5}");
        }
        Console.WriteLine("|");
    }
}

// int SumElementsFromDiagonal(int[,] matrix)
// {
//     int sum = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (i == j)
//                 sum += matrix[i, j];
//         }
//     }
//     return sum;
// }

int SumElementsFromDiagonal(int[,] matrix)
{
    int sum = 0;
    int minLength = matrix.GetLength(1);
    if (matrix.GetLength(0) < matrix.GetLength(1))
        minLength = matrix.GetLength(0);
    for (int i = 0; i < minLength; i++)
        sum += matrix[i, i];
    return sum;
}

int[,] array2D = CreateMatrixRndInt(6, 4, -100, 100);
PrintMatrix(array2D);

int amount = SumElementsFromDiagonal(array2D);
Console.Write($"Сумма элементов, находящихся на главной диагонали, равна {amount}");
