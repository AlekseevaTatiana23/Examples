// Задайте двумерный массив.
// Напишите программу,
// которая заменяет строки на столбцы.
// В случае, если это невозможно,
// программа должна вывести сообщение для пользователя.

int rowMatrix = Prompt("Введите количество строк в массиве m: ");
int columnMatrix = Prompt("Введите количество столбцов в массиве n: ");
int[,] array2d = FillMatrixRndInt(rowMatrix, columnMatrix, 1, 10);
PrintMatrix(array2d);
ReplaceRowsAndColumns(array2d);
Console.WriteLine();
PrintMatrix(array2d);


int[,] FillMatrixRndInt(int rows, int columns, int min, int max)
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

void ReplaceRowsAndColumns(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0)-1; i++)
    {
        for (int j = i+1; j < matrix.GetLength(1); j++)
        {
            int value = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = value;
        }
    }
}

int Prompt(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
