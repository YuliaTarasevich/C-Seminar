// Напишите программу, которая 
// 1. принимает на вход цифру, обозначающую день недели, и 
// 2. проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int num = Prompt("Введите число, соответствующее дню недели");
if (IsDayWeek(num))
{
    Weekend(num);
}

int Prompt(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

bool IsDayWeek(int number)
{
    if (number < 1 || number > 7)
    {
        Console.WriteLine("Ошибка ввода");
        return false;
    }
    return true;
}

void Weekend(int number)
{
    if (number == 6 || number == 7)
    {
        Console.WriteLine("ДА");
    }
    else
    {
        Console.WriteLine("НЕТ");
    }
}