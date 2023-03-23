// Составить частотный словарь элементов двумерного массива.
// Содержит инфу о том, сколько раз встречается элемент 
// входных данных.



int[,] array2d = FillMatrixRndInt(5, 5, 1, 10);
PrintMatrix(array2d);
int[] arr = MatrixToArray(array2d);
Console.WriteLine();
Array.Sort(arr); //сортирует от мин до макс, а то метод не работает верно
PrintArray(arr);
Console.WriteLine();
Dictionary(arr);


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

int[] MatrixToArray(int[,] matrix)
{
    int[] array = new int[matrix.Length];
    int count=0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[count++] = matrix[i,j];
            // count++;
        }
    }
    return array;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}


void Dictionary(int[] arr)
{
    int count=1;
    int temp=arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (temp == arr[i]) count++;
        else
        {
            Console.WriteLine($"{temp} ---> {count}");
            temp=arr[i];
            count=1;
        }
    }
    Console.WriteLine($"{temp} ---> {count}");
}
