// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2


int length = Prompt("Длина массива: ");
int min = Prompt("Начальное значение для диапазона случайного числа: ");
int max = Prompt("Конечное значение для диапазона случайного числа: ");
double[] array = Generate(length, min, max);
PrintArray(array);
double maxNum = MaxNumber(array);
double minNum = MinNumber(array);
double difference = Difference(maxNum, minNum);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {difference}");

int Prompt(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

double[] Generate(int Length, int minValue, int maxValue)
{
    double[] arr = new double[Length];
    Random rand = new Random();
    for (int i = 0; i < Length; i++)
    {
        double num = rand.NextDouble() * (maxValue - minValue) + minValue;
        arr[i] = Math.Round(num, 1);
    }
    return arr;
}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.WriteLine($"{arr[i]}]");
    }
}

double MaxNumber(double[] arr)
{
    double maxNumber = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > maxNumber) maxNumber = arr[i];
    }
    return maxNumber;
}

double MinNumber(double[] arr)
{
    double minNumber = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < minNumber) minNumber = arr[i];
    }
    return minNumber;
}

double Difference(double maxNumber, double minNumber)
{
    double maxNum = maxNumber, minNum = minNumber;
    double diff = 0;
    return diff = Math.Round(maxNum - minNum, 1);
}