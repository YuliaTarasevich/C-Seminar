// Напишите программу, которая 
// 1. на вход принимает два числа и 
// 2. проверяет, является ли первое число квадратом второго.
// Например :
// a = 25, b = 5 -> да
Console.WriteLine("Введите первое целое число");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число");
int secondNumber = Convert.ToInt32(Console.ReadLine());
if (firstNumber == secondNumber * secondNumber)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}