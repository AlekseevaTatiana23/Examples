// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int i = Prompt("Введите количество строк первой матрицы: ");
int j = Prompt("Введите количество столбцов первой матрицы: ");
int k = Prompt("Введите количество строк второй матрицы: ");
int l = Prompt("Введите количество столбцов второй матрицы: ");
Console.WriteLine();
int[,] firstArray2d = FillMatrixRnd(i, j, 1, 10);
PrintMatrix(firstArray2d);
Console.WriteLine();
int[,] secondArray2d = FillMatrixRnd(k, l, 1, 10);
PrintMatrix(secondArray2d);
Console.WriteLine();
bool checkmatrix= CheckMatrix(firstArray2d, secondArray2d);


if (checkmatrix)
{
   int[,] multiplicationmatrix = MultiplicationMatrix(firstArray2d, secondArray2d);
    PrintMatrix(multiplicationmatrix);
}



int Prompt(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

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

int[,] MultiplicationMatrix(int[,] firstmatrix, int[,] secondmatrix)
{
    int sumMultiply = 0;
    int[,] multiplymatrix = new int[firstmatrix.GetLength(0), secondmatrix.GetLength(1)];
    for (int i = 0; i < firstmatrix.GetLength(0); i++)
    {
        for (int l = 0; l < secondmatrix.GetLength(1); l++)
        {
            for (int j = 0; j < secondmatrix.GetLength(0); j++)
            {
                sumMultiply += firstmatrix[i, j] * secondmatrix[j, l];
                multiplymatrix[i, l] = sumMultiply;
            }
            sumMultiply = 0;
        }
    }
    return multiplymatrix;
}


bool CheckMatrix(int[,] firstmatrix, int[,] secondmatrix)
{
    if (firstmatrix.GetLength(1) != secondmatrix.GetLength(0))
    {
        Console.WriteLine("Матрицы нельзы перемножить");
        return false;
    }
    return true;
}