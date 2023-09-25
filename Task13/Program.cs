// Напишите программу, которая 
// 1. выводит третью цифру заданного числа или 
// 2. сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int num = Prompt("Введите число");
if (IsNumberOk(num))
{
    Console.WriteLine(ThirdDigit(num));
}

int Prompt(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}


int ThirdDigit(int number)
{
    while (number > 999)
    {
        number = number / 10;
    }
    return number % 10;
}

bool IsNumberOk(int number)
{
    if (number < 100)
    {
        Console.WriteLine("Третьей цифры нет");
        return false;
    }
    return true;
}
