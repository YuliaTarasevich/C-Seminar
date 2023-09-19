// Напишите программу, которая 
// 1.на вход принимает одно число (N), 
// 2. а на выходе показывает все целые числа в промежутке от -N до N
Console.WriteLine("Введите целое натуральное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0)
{
    int N = -number;
    while (N <= number)
    {
        Console.Write($" {N}");
        N++;
    }
}
else
{
    Console.WriteLine("Ошибка ввода");
}