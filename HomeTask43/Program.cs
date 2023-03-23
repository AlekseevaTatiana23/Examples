// Задача 43: Напишите программу, 
// которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


int b1 = Prompt("Введите коэффициент b1: ");
int k1 = Prompt("Введите коэффициент k1: ");
int b2 = Prompt("Введите коэффициент b2: ");
int k2 = Prompt("Введите коэффициент k2: ");
double x = FindX(b1, b2, k1, k2);
double y = FindY(b1, k1, x);
bool check = Check(b1, b2, k1, k2);

if (check)
{
    Print(x, y);
}

int Prompt(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

double FindX(int B1, int B2, int K1, int K2)
{
    double num1 = (B2 - B1) / (K1 - K2);
    double x = Math.Round(num1, 1);
    return x; 
}

double FindY(int B1, int K1, double X)
{
    double num2 = K1 * X + B1;
    double y = Math.Round(num2, 1);
    return y;
}
void Print(double X, double Y)
{
    Console.WriteLine($"({x}, {Y})");
}

bool Check(int B1, int B2, int K1, int K2)
{
    if (B1 == B2 || K1 == K2)
    {
        Console.WriteLine("Прямые не пересекаются");
        return false;
    }
    return true;
}