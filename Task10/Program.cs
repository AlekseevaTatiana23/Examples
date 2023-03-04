// Задача 10: Напишите программу, 
// которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// int number = new Random().Next(100,1000);
// Console.WriteLine($"Случайное число из отрезка 100 - 999 - > {number}");
// int firstDigit = number / 10;
// int secondDigit = firstDigit % 10;
// Console.WriteLine($"Вторая цифра числа - > {secondDigit}");



// // второй метод
Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
int secDigit = SecDigit (number);
bool validatenumber = ValidateNumber(number);

if (validatenumber)
{
Console.WriteLine($"Вторая цифра числа - > {secDigit}");
}



int SecDigit (int num) // num=number
{
    return secDigit=(num/10)%10;
}

bool ValidateNumber(int num)
{
    if (num < 100 || num >= 1000)
    {
        Console.WriteLine("Вы ввели не трехзначное число");
        return false;
    }
    return true;
}