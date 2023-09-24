// Напишите программу, которая будет
// 1. принимать на вход два числа и 
// 2. выводить, является ли первое число кратным второму.
// 3. Если число 1 не кратно числу 2, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно.
Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());

int remainder1 = Multiplicity(number1,number2);
ResultProgram(remainder1);

int Multiplicity(int num1, int num2)
{
    int remainder = num1 % num2;
    return remainder;
}
void ResultProgram(int remainderNum)
{
    if (remainderNum == 0)
    {
        Console.WriteLine("Кратно");
    }
    else
    {
        Console.WriteLine($"Не кратно. Остаток от деления равен {remainderNum}");
    }
}