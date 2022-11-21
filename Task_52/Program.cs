// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

double[] ArithmeticMean(int[,] matrix)
{
    int size = matrix.GetLength(1);
    double[] arithmeticMean = new double[size];
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            double sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sum += matrix[i, j];
            }
            arithmeticMean[j] = sum / matrix.GetLength(0);
            arithmeticMean[j] = Math.Round(arithmeticMean[j], 1);
        }
    return arithmeticMean;
}

void PrintArray(double[] array)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
            Console.Write($"{array[i]}; ");
        else
            Console.Write($"{array[i]}");
    }
}
int[,] array2D = CreateMatrixRndInt(3, 4, -100, 100);
PrintMatrix(array2D);

double[] resalt = ArithmeticMean(array2D);
PrintArray(resalt);
