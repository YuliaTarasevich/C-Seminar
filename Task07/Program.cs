// Напишите программу, которая 
// 1. принимает на вход трехзначное число и 
// 2. на выходе показывает последнюю цифру этого числа.
Console.WriteLine("Введите трехзначное число:");
int number = Convert.ToInt32(Console.ReadLine());
if (99 < number && number < 1000)
{
    int result = number % 10;
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Ошибка ввода");
}