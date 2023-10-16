// Напишите программу, 
// которая принимает  на вход число и 
// выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int Prompt(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int NumberAmount(int number)
{
    if (number < 0)
    {
        number = number * (-1);
    }
    int amount = 0;
    while (number > 0)
    {
        number = number / 10;
        amount++;
    }
    return amount;
}

int numBer = Prompt("Введите целое число");
int finish = NumberAmount(numBer);
Console.WriteLine(finish);