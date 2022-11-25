// Задача 58: Задайте две матрицы.
// Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
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

int[,] MatrixProduct(int[,] matrixA, int[,] matrixB)
{
    int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    for (int i = 0; i < matrixC.GetLength(0); i++)
    {
        for (int j = 0; j < matrixC.GetLength(1); j++)
        {
            int sum = 0;
            matrixC[i, j] = sum;
            for (int k = 0; k < matrixA.GetLength(1); k++)
            {
                matrixC[i, j] = matrixC[i, j] + matrixA[i, k] * matrixB[k, j];
            }
        }
    }
    return matrixC;
}

Console.WriteLine("Введите количество строк первой матрицы: ");
int rowFirstMatrix = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов первой матрицы: ");
int columnFirstMatrix = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество строк второй матрицы: ");
int rowSecondMatrix = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов второй матрицы: ");
int columnSecondMatrix = Convert.ToInt32(Console.ReadLine());

if (columnFirstMatrix != rowSecondMatrix)
    Console.WriteLine(
        "Ошибка. Количество столбцов первой матрицы должно быть равно количеству строк второй матрицы."
    );
    else
    if (rowFirstMatrix <= 0 || columnFirstMatrix <= 0 || rowSecondMatrix <= 0 || columnSecondMatrix <= 0) Console.WriteLine(
        "Ошибка. Количество строк/столбцов не может быть отрицательным или равняться 0."
    );
else
{
    Console.WriteLine("Первая матрица: ");
    int[,] firstMatrix = CreateMatrixRndInt(rowFirstMatrix, columnFirstMatrix, 0, 5);
    PrintMatrix(firstMatrix);

    Console.WriteLine();

    Console.WriteLine("Вторая матрица: ");
    int[,] secondMatrix = CreateMatrixRndInt(rowSecondMatrix, columnSecondMatrix, 0, 5);
    PrintMatrix(secondMatrix);

    Console.WriteLine();

    Console.WriteLine("Произведение матриц: ");

    int[,] thirdMatrix = MatrixProduct(firstMatrix, secondMatrix);
    PrintMatrix(thirdMatrix);
}
