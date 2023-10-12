// Напишите программу, 
// 1. которая по заданному номеру четверти, 
// 2. показывает диапазон возможных координат точек в этой четверти (x и y).

string Prompt(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    return value;
}

string rangeCoordinates(string NumQuarter)
{
    if (NumQuarter == "1") return "x > 0, y > 0";
    if (NumQuarter == "2") return "x < 0, y > 0";
    if (NumQuarter == "3") return "x < 0, y < 0";
    if (NumQuarter == "4") return "x > 0, y < 0";
    return "Ошибка ввода";
}

string numQuarter = Prompt("Введите номер четверти");
string RangeCoordinates = rangeCoordinates(numQuarter);

Console.WriteLine(RangeCoordinates);