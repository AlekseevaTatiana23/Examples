// Напишите программу, которая принимает
// на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да
// .


Console.WriteLine("Введите пятизначное число:");
int number = Convert.ToInt32(Console.ReadLine());


bool validatenumber = ValidateNumber (number);
bool result = Result (number);
if  (validatenumber)
{
   Console.WriteLine(result ? "Да" : "Нет");
}


bool Result (int num)
{
    return ((num % 10) *10000 + ((num/10)%10)*1000 + ((num/100)%10)*100 + ((num/1000)%10)*10 + num/10000) == num;
}

bool ValidateNumber (int num1)
{
    if  (num1 > 9999 && num1 < 100000) 
    {
        return true;
    }
    Console.WriteLine("Некорректный ввод");
    return false;
}
