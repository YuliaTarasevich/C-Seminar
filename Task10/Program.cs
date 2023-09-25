// Напишите программу, которая 
// 1. принимает на вход трёхзначное число и 
// 2. на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int num = Prompt("Введите трехзначное число");
if (IsNumberOk(num))
{
    Console.WriteLine(SecondDigit(num));
}


int Prompt(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}


bool IsNumberOk(int number)
{
    if (number < 100 || number > 999)
    {
        Console.WriteLine("Ошибка ввода");
        return false;
    }
    return true;
}

int SecondDigit(int number)
{
    int quotient = number / 10;
    int remainder = quotient % 10;
    return remainder;
}