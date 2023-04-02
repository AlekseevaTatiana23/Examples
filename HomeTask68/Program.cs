// Задача 68: Напишите программу вычисления функции Аккермана
//  с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29



int numberM = Prompt("Введите натуральное число M: ");
int numberN = Prompt("Введите натуральное число N: ");
Console.WriteLine();
bool checkNumbers = CheckNumbers(numberN, numberM);

if (checkNumbers) 
{
    int functionAkkerman = FunctionAkkerman(numberM, numberN);
    Console.WriteLine($"A(m, n) = {functionAkkerman}");
}

int Prompt(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}


int FunctionAkkerman(int numM, int numN)
{
    while (numM !=0)
    {
    if (numN== 0) numN=1;
    else numN=FunctionAkkerman(numM, numN-1);
    numM=numM-1;
    }
    return numN + 1;
}

bool CheckNumbers(int numM, int numN)
{
    if (numM < 0 || numN < 0)
    {
        Console.WriteLine("Вы ввели отрицательное число! ");
        return false;
    }
    return true;
}

