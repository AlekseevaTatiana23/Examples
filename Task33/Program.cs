// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да


void FillArray(int[] arr)
{
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(-10, 11);
    }
}

void PrintArray (int[] arr)
{
    Console.Write ("[");
    for (int i = 0; i < arr.Length; i++)
    {
      if (i<arr.Length-1) Console.Write($"{arr[i]}, ");
      else Console.Write($"{arr[i]} ");
    }
    Console.WriteLine ("]");
}

bool NumberExist (int[] arr, int num)
{
    for (int i = 0; i < arr.Length; i++)
    {
      if (arr[i] == num) return true;
    }
    return false;
}

int[] array = new int[5];
Console.WriteLine("Введите число от -10 до 10");
int number = Convert.ToInt32(Console.ReadLine());
FillArray(array);
PrintArray(array);

bool numberExist = NumberExist(array, number);
Console.WriteLine(numberExist ? "Да" : "Нет");