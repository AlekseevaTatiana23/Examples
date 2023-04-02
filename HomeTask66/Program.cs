// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N. Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int numberM = Prompt("Введите натуральное число M: ");
int numberN = Prompt("Введите натуральное число N: ");
Console.WriteLine();
bool checkNumbers = CheckNumbers(numberN, numberM);
int sumNumbers = SumNumbers(numberN, numberM);
if (checkNumbers) Console.WriteLine($"{sumNumbers}");

int Prompt(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}


int SumNumbers(int numM, int numN)
{
    if (numM == numN) return numM;
    else if (numM<numN) return numM + SumNumbers(numM + 1, numN);
    return numM + SumNumbers(numM - 1, numN);
}

bool CheckNumbers(int numM, int numN)
{
    if (numM < 0 || numN < 0)
    {
        Console.WriteLine("Вы ввели отрицательное число! ");
        return false;
    }
    return true;
}