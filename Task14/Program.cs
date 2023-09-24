// Напишите программу, которая
// 1. принимает на вход число и 
// 2. проверяет кратно ли оно одновременно 7 и 23.
// 7 -> нет
// 46 -> нет
// 161 -> да
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое число для проверки кратности");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число для проверки кратности");
int secondNumber = Convert.ToInt32(Console.ReadLine());

bool result = IsMultipleTwoNumber(number,firstNumber,secondNumber);
Console.WriteLine(result?"Число кратно данным числам":"Число не кратно данным числам");

bool IsMultipleTwoNumber(int num, int firstNum, int secondNum)
{
    return num % firstNum == 0 && num % secondNum == 0;
}