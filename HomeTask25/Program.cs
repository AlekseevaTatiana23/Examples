// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


int number = Prompt("Введите число A: ");
int exponent = Prompt("Введите степень B: ");
if (Validate(exponent))
{
Console.WriteLine($"Число {number} в степени {exponent}= {Power(number, exponent)}");
}


int Prompt(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int Power (int num, int exp)
{
    int power = 1;
    for (int i = 0; i < exp; i++)
    {
        power *=num;
    }
    return power;
}

bool Validate (int exponent)
{
    if (exponent < 0)
    {
        Console.WriteLine("Показатель не должен быть меньше нуля");
        return false;
    }
    return true;
}