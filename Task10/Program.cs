// Напишите программу, которая 
// 1. принимает на вход трёхзначное число и 
// 2. на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число:");
int number = Convert.ToInt32(Console.ReadLine());

int result = SecondDigit(number);
Console.WriteLine(result);

int SecondDigit(int num)
{
    int secondDigit = -1;
    if (num > 99 && num < 1000)
    {
        int quotient = num / 10;
        secondDigit = quotient % 10;
    }
    else
    {
        Console.WriteLine("Ошибка ввода");
        return -1;
    }
    return secondDigit;
}
