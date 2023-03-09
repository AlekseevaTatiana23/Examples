// Задача 28: Напишите программу, которая
// принимает на вход число N и 
// выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120


Console.WriteLine("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int multiplication = Multiplication(number);
if (number > 0)
{
    Console.WriteLine($"Произведение чисел от 1 до {number} = {multiplication}");
}
else
{
    Console.WriteLine("Введите целое положительное число! ");
}

int Multiplication(int num)
{
    int mult = 1;
    for (int i = 1; i <= num; i++)
    {
        checked
        {
            mult *= i; // mult = mult * i;
        }
    }
    return mult;
}