// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int number = Prompt("Введите число: ");

int sumnumbers = SumNumbers(number);
Console.WriteLine($"{sumnumbers}");



int SumNumbers(int num)
{
    if (num == 0) return 0;
    else return num % 10 + SumNumbers(num / 10);
}


int Prompt(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
