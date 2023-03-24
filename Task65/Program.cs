// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"


// Console.Write("Введите первое значение: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе значение: ");
// int n = Convert.ToInt32(Console.ReadLine());

// if (n <= 0 || m <= 0) 
// {
//     Console.WriteLine("Введено неверное значение.");
// }
// else DiaposonNumber(m, n);

// void DiaposonNumber(int numM, int numN)
// {
//     if (numM > numN)
//     {
//         Console.Write(numM);
//         DiaposonNumber(numM - 1, numN);
//     }
//     else if (numM < numN)
//     {
//         Console.Write(numM);
//         DiaposonNumber(numM + 1, numN);
//     }
//     else Console.Write(numM); 

// }

int numberM = Input("Введите целое положительное число M: ");
int numberN = Input("Введите целое положительное число N: ");
NaturalNumbersMtoN(numberM, numberN);

void NaturalNumbersMtoN(int numM, int numN)
{
    if (numM < numN)
    {
        Console.Write($"{numM} ");
        NaturalNumbersMtoN(numM + 1, numN);
    }

    else if (numM > numN)
    {
        Console.Write($"{numM} ");
        NaturalNumbersMtoN(numM - 1, numN);
    }

    else
    {
        Console.Write($"{numM}");
    }
}

int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}