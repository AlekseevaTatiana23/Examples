﻿// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]


int[] array = new int[8];
FillArray(array);
PrintArray(array);

void FillArray(int[] arr)
{
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        arr[i] = rand.Next(0, 2);
    }
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}