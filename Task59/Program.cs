// 

int rowMatrix = Prompt("Введите количество строк в массиве m: ");
int columnMatrix = Prompt("Введите количество столбцов в массиве n: ");
int[,] array2d = FillMatrixRndInt(rowMatrix, columnMatrix, 1, 10);
PrintMatrix(array2d);
Console.WriteLine();

int[] minElemIndexes = MinElemIndexes(array2d);
int[,] newmatrix = DeleteMinRowColumn(array2d, minElemIndexes[0], minElemIndexes[1]);
PrintMatrix(newmatrix);


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

int [,] DeleteMinRowColumn (int[,] matrix, int rowDel, int columnDel)
{
    int[,] newmatrix = new int[matrix.GetLength(0)-1, matrix.GetLength(1)-1 ];
    int m=0, n=0;
    for (int i = 0; i < newmatrix.GetLength(0); i++)
    {
        if (m==rowDel) m++;
        for (int j = 0; j < newmatrix.GetLength(1); j++)
        {
            if (n==columnDel) n++;
            newmatrix[i,j]=matrix[m,n];
            n++;
        }
        n=0;
        m++;
    }
    return newmatrix;
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

int[] MinElemIndexes(int[,] matrix)
{
    int row=0, column=0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i,j]< matrix[row,column])
            {
                row=i;
                column=j;
            }
        }
    }
    return new int[]{row,column};
}

int Prompt(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

