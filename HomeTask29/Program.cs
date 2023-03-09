// Задача 29: Напишите программу, 
// которая задаёт массив из 8 элементов 
// и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int length = Prompt ("Длина массива: ");
int min = Prompt ("Начальное значение для диапазона случайного числа: ");
int max = Prompt ("Конечное значение для диапазона случайного числа: ");
int [] arr = Generate (length, min, max);
PrintArray (arr);

int Prompt (string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int [] Generate (int Length, int minValue, int maxValue)
{
    int [] array = new int [Length];
    Random rand = new Random();
    for (int i = 0; i < Length; i++)
    {
        array[i] = rand.Next(minValue, maxValue+1);
    }
    return array;
}

void PrintArray(int [] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length-1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write($"{arr[arr.Length-1]}] "); 
}