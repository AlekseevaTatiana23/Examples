// 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4


Console.WriteLine("введите число N");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0)
{
    Square (number);
}
else
{
   Console.WriteLine("Введено некорректное число");
}

void Square (int num)
{
    int i = 1;
    while (i <= num )
     {
         Console.WriteLine($"{i, 4} -> {Math.Pow(i, 2), 4}");
         i++;
    }
}


// Console.Write("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// Method(n);

// void Method (int a)
// {
//     if (a > 0)
//     {
//         for (int i = 1; i <= a; i++)
//         {
//             Console.WriteLine($"{i} -- {i * i}");
//         }
//         return;
//     }
//     else 
//     {
//         for (int i = 1; i >= a; i--)
//         {
//             Console.WriteLine($"{i} -- {i * i}");
//         }
//         return;
//     }
// }