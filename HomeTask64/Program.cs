// Задача 64: Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа 
// в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int number = Prompt("Введите натуральное число N: ");
Console.WriteLine();
bool checkNumber = CheckNumber(number);
if (checkNumber) NaturalNumbers(number);

int Prompt(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

void NaturalNumbers(int num)
{
    if (num == 0) return;
    Console.WriteLine(num);
    NaturalNumbers(num - 1);
}

bool CheckNumber(int num)
{
    if (num < 0 )
    {
        Console.WriteLine("Вы ввели отрицательное число! ");
        return false;
    }
    return true;
}