// Задача 49: Задайте двумерный массив.
// Найдите элементы, у которых оба индекса четные, 
// и замените эти элементы на их квадраты.


int[,] array2d = CreateMatrixRndInt(3,4, 1, 10);
PrintMatrix (array2d);
Console.WriteLine();
ReplaceNumberToSquare(array2d);
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
            Console.Write($"{matrix[i,j], 5} ");
        }
        Console.WriteLine();
    }
}

void ReplaceNumberToSquare(int[,] matrix)
{
    // int[,] matrix = new int [rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i+=2)
    {
        for (int j = 0; j < matrix.GetLength(1); j+=2)
        {
            if (i%2 == 0 && j%2 ==0)
            {
               matrix[i,j]*=matrix[i,j];
            }
        }
    }
}