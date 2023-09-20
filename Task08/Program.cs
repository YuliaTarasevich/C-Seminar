// Напишите программу, которая 
// 1. на вход принимает число (N), а 
// 2. на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.WriteLine("Введите натуральное число:");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0)
{
    int N = 1;
    while (N <= number)
    {
        if (N % 2 == 0)
        {
            Console.Write($"{N} ");
        }
        N++;
    }
}
else
{
    Console.WriteLine("Введите НАТУРАЛЬНОЕ (целое положительное) число");
}