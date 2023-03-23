// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int length = Prompt("Введите количество чисел M: ");

int[] array = Generate(length);
PrintArray(array);
int positiveElem = PositiveElem(array);
Console.WriteLine($" -> Количество положительных элементов массива равно {positiveElem}");

int Prompt(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[] Generate(int Length)
{
    int[] arr = new int[Length];
    for (int i = 0; i < Length; i++)
    {
       arr[i] = Prompt($"Введите {i+1} элемент: ");
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}]");
    }
}

int PositiveElem (int[] arr)
{
    int count =0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count+=1;
    }
    return count; 
}