// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12


// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

int number = Prompt("Введите число: ");
Console.WriteLine($"Сумма всех цифр в числе {number} = {Sum(number)}");



int Prompt(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}


int Sum (int num)
{
    int result =0;
    while (num !=0)
    {
     result += num % 10;
     num = num / 10;
    }
    return result;
}