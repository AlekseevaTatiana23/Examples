// Задача 8: Напишите программу, которая 
// на вход принимает число (N),
//  а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("введите натуральное число N");
int number = Convert.ToInt32(Console.ReadLine());
int count=2;
if (number > 0)
{
    while (count<=number)
    {
    Console.WriteLine(count);
    count=count+2;
    }
}
else
{
   Console.WriteLine($"Число {number} не натуральное"); 
}