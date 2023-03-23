// Задайте двумерный массив.
// Найдите сумму элементов, находящихся на главной диагонали
// (с индексами (0,0), (1,1) и т.д.)

int[,] array2d = CreateMatrixRndInt(3,4, 1, 10);
PrintMatrix (array2d);
Console.WriteLine();
int sumElemOnDiagonal=SumElemOnDiagonal(array2d);
Console.WriteLine($"Сумма элементов, находящихся на главной диагонали равна {sumElemOnDiagonal}");

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
            Console.Write($"{matrix[i,j], 5} ");
        }
        Console.WriteLine();
    }
}

int SumElemOnDiagonal (int[,] matrix)
{
    // int sum=0;
    // for (int i = 0; i < matrix.GetLength(0); i++)
    // {
    //     for (int j = 0; j < matrix.GetLength(1); j++)
    //     {
    //         if (i == j)
    //         {
    //           sum+=matrix[i,j];
    //         }
    //     }
    // }
    // return sum;

    // оптимизация
    int sum=0;
    for (int i = 0; i < matrix.GetLength(1) && i < matrix.GetLength(0); i++)
    {
        sum+=matrix[i,i];
    }
    return sum;
}