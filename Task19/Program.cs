// Напишите программу, которая 
// 1. принимает на вход пятизначное число и 
// 2. проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int Prompt(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int ReverseNumber(int num)
{
    if (num < 0)
    {
        num = num * -1;
    }
    int res = 0;
    while (num > 0)
    {
        res *= 10;
        res = res + num % 10;
        num = num / 10;
    }
    return res;
}

bool IsPalindrome(int num, int res)
{
    if (num < 0)
    {
        num = num * -1;
    }
    if (res == num)
    {
        Console.WriteLine("Да");
        return true;
    }
    Console.WriteLine("Нет");
    return false;
}

int numBer = Prompt("Введите число");
int reverseNumber = ReverseNumber(numBer);
bool answer = IsPalindrome(numBer, reverseNumber);

