// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку
// с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка.


int[,] array2d = FillMatrixRnd(4, 4, 1, 10);
PrintMatrix(array2d);
int[,] sumElemInRows = SumElemInRow(array2d);
Console.WriteLine();
int rowWithMinSumElem = RowWithMinSumElem(sumElemInRows);
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {rowWithMinSumElem} строка");

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

int[,] SumElemInRow(int[,] matrix)
{
    int sum = 0;
    int[,] newmatrix = new int[matrix.GetLength(0), 1];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
            
        }
        newmatrix[i, 0] = sum;
        sum = 0;
    }
    return newmatrix;
}

int RowWithMinSumElem (int[,] newmatrix)
{
    int j=0;
    int min=0;
    for (int i = 1; i < newmatrix.GetLength(0); i++)
    {
       if (newmatrix[i, j]<newmatrix[min, j]) min=i;
    }
    return min+1;
}



