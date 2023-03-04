// Задача 15: Напишите программу, 
// которая принимает на вход цифру, 
// обозначающую день недели, и проверяет,
//  является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите день недели");
int day=Convert.ToInt32(Console.ReadLine());

bool checkday = CheckDay (day);
bool validateday = ValidateDay (day);
if (validateday)
{
    Console.WriteLine(checkday ? "да" : "нет");
}


bool CheckDay (int weekday)
{
    if (weekday > 5 )
    {
        return true;
    }
    return false;
}

bool ValidateDay (int days)
{
    if (days > 0 && days <= 7 )
    {
        return true;
    }
    Console.WriteLine("Это не день недели");
    return false;
}