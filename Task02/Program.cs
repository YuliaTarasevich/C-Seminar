//  Напишите программу, которая 
//  1. на вход принимает два числа и 
//  2. выдаёт, какое число большее, 
//  3. а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
Console.WriteLine("Введите первое число");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int secondNumber = Convert.ToInt32(Console.ReadLine());
if (firstNumber > secondNumber)
{
    Console.WriteLine($"max={firstNumber}");
    Console.WriteLine($"min={secondNumber}");
}
else
{
    Console.WriteLine($"max={secondNumber}");
    Console.WriteLine($"min={firstNumber}");
}