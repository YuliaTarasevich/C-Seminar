// Напишите программу, которая 
// принимает на вход число и 
// выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


int Prompt(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    int finish = Convert.ToInt32(value);
    return finish;
}

int SummNumbers (int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum = sum + num % 10;
        num = num / 10;
    }
    return sum;
}

int number = Prompt("Введите число:");
int result = SummNumbers(number);
Console.WriteLine(result);