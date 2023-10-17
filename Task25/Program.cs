// Напишите цикл, который 
// принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


int Prompt(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    int finish = Convert.ToInt32(value);
    return finish;
}

bool IsNumberBOk(int number)
{
    if (number <= 0)
    {
        Console.WriteLine("Ошибка ввода, введите целое положительное значение степени");
        return false;
    }
    return true;
}

int Exponentiation(int basDegree, int degree)
{
    int num = 1;
    for (int i = 1; i <=degree; i++)
    {
        num = num * basDegree;
    }
    return num;
}

int numberA = Prompt("Введите число A");
int numberB = Prompt("Введите значение степени B");

if (IsNumberBOk(numberB))
{
    int result = Exponentiation(numberA,numberB);
    Console.WriteLine($"{numberA} в степени {numberB} -> {result}");
}

