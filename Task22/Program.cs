// Напишите программу, которая
// 1. принимает на вход число (N) и 
// 2. выдаёт таблицу квадратов чисел от 1 до N.

int Prompt(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

bool IsNumberOk(int num)
{
    if (num < 1)
    {
        return false;
    }
    return true;
}

void Square (int number)
{
    for (int i=1; i<=number;i++)
    {
        Console.WriteLine($"{i,3}  {Math.Pow(i,2),3}");
    }
}


int numBer = Prompt("Введите целое число");
if(IsNumberOk(numBer))
{
    Square(numBer);
}
else
{
    Console.WriteLine("Ошибка ввода. Введите ЦЕЛОЕ число");
}

