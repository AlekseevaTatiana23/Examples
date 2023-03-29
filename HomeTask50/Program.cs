﻿// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1, 7 -> такого элемента в массиве нет.


int[,] array2d = FillMatrixRnd(3, 4, -10, 10);
PrintMatrix(array2d);
Console.WriteLine();
int i = Prompt("Введите номер строки: ");
int j = Prompt("Введите номер столбца: ");
Console.WriteLine();
PrintElement(array2d);

int[,] FillMatrixRnd(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max+1);
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
            Console.Write($"{matrix[i, j],6} ");
        }
        Console.WriteLine();
    }
}

void PrintElement(int[,] matrix)
{
    if (i < matrix.GetLength(0) && j < matrix.GetLength(1) && i>0 && j>0)
    {
        Console.WriteLine($"{i}, {j} -> {matrix[i-1, j-1]} ");
    }
    else Console.WriteLine($"{i}, {j} -> Такого элемента в массиве нет");
}

int Prompt(string message)
{
    Console.WriteLine(message);
    int result=Convert.ToInt32(Console.ReadLine());
    return result;
}