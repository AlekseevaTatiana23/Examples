// Задача 13: Напишите программу, 
// которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.WriteLine("Введите чиcло: ");
int number = Convert.ToInt32(Console.ReadLine());

int thirdDigit = ThirdDigit(number);
bool validatenumber = ValidateNumber(number);

if (validatenumber)
{
    Console.WriteLine(thirdDigit);
}


bool ValidateNumber(int num)
{
    if (num < 100)
    {
        Console.WriteLine("Третьей цифры нет");
        return false;
    }
    return true;
}
int ThirdDigit(int num)
{
    while (num > 999)
    {
        num /= 10;
    }
    return num % 10;
}