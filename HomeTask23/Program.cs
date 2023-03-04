// Задача 23
// Напишите программу, которая 
// принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());


if (N > 0)
{
    Cube (N);
}
else
{
   Console.WriteLine("Введено некорректное число");
}

void Cube (int number)
{
    int i = 1;
    while (i <=number)
    {
        Console.WriteLine($"{i, 4} -> {Math.Pow(i, 3), 4}");
        i ++;
    }
}


// Console.Write("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// Method(n);

// void Method (int number)
// {
//     if (number > 0)
//     {
//         for (int i = 1; i <= number; i++)
//         {
//             Console.WriteLine($"{i, 4} -- {Math.Pow(i, 3), 4}");
//         }
//         return;
//     }
//     else 
//     {
//         for (int i = 1; i >= number; i--)
//         {
//             Console.WriteLine($"{i, 4} -- {Math.Pow(i, 3), 4}");
//         }
//         return;
//     }
// }