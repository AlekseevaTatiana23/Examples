// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).


Console.WriteLine("Введите номер четверти");
Console.Write("Четверть: ");
int quarter = Convert.ToInt32(Console.ReadLine());


string coordinates = Coordinates(quarter);
string result = coordinates!= "ERROR"
                ? $"Указанная четверть соответствует координатам - {coordinates}"
                : "Введена некорректная четверть";

Console.WriteLine(result);


string Coordinates(int quart)
{
    if (quart==1) return "x>0, y>0";
    if (quart==2) return "x<0, y>0";
    if (quart==3) return "x<0, y<0";
    if (quart==4) return "x>0, y<0";
    return "ERROR";
}