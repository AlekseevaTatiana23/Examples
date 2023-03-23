// Задайте двумерный массив. 
// Напишите программу, которая поменяет местами 
// первую и последнюю строку массива


int[,] array2d = FillMatrixRnd(3, 4, 1, 10);
PrintMatrix(array2d);
ReplaceRows(array2d);
Console.WriteLine();
PrintMatrix(array2d);


int[,] FillMatrixRnd(int rows, int columns, int min, int max)
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
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5} ");
        }
        Console.WriteLine();
    }
}

void ReplaceRows(int[,] matrix)
{
    int firstRowIndex=0;
    int lastRowIndex=matrix.GetLength(0)-1;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int temp = matrix[firstRowIndex,j];
        matrix[firstRowIndex, j]=matrix[lastRowIndex,j];
        matrix[lastRowIndex, j]=temp;
    }
}

