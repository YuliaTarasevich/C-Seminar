// Напишите программу, 
// которая принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

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
    Console.WriteLine("-------------");
    for (int i=1; i<=number;i++)
    {
        Console.WriteLine($"|{i,4} | {Math.Pow(i,3),4}|");
    }
    Console.WriteLine("-------------");
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
