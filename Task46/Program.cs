// Задача 46: Задайте двумерный массив размером m x n , 
// заполненный случайными целыми числами.
// m=3, n=4.

// 1   4  8   19
// 5  -2  33  -2
// 77  3  8    1

int[,] array2d = CreateMatrixRndInt(3,4, 1, 100);
PrintMatrix (array2d);

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int [rows, columns];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(min, max+1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j], 3} ");
        }
        Console.WriteLine();
    }
}