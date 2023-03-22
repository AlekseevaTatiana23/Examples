// Задача 34: 
// Задайте массив заполненный случайными 
// положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int length = Prompt ("Длина массива: ");
int[] array = new int[length];
FillArray(array);
PrintArray (array);
int quantity = Quantity(array);
Console.Write($" -> Количество чётных чисел в массиве равно {quantity}");

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
        arr[i] = rand.Next(100, 1000);
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


int Quantity (int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]%2 == 0) count+=1;
    }
    return count;
}