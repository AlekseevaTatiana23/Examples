// Задача 36: 
// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int length = Prompt ("Длина массива: ");
int[] array = new int[length];
FillArray(array);
PrintArray (array);
int sumNumbers = SumNumbers(array);
Console.Write($" -> Сумма элементов на нечётных позициях равна {sumNumbers}");

int Prompt (string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

void FillArray(int[] arr)
{
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(-100, 101);
    }
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
       if (i< arr.Length -1) Console.Write($"{arr[i]}, ");
       else Console.Write($"{arr[i]} ]");
    }
}


int SumNumbers (int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i %2 != 0) sum+=arr[i];
    }
    return sum;
}