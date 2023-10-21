// Напишите программу, 
// которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10



int DecToBin(int num)
{
    int res = 0;
    int countNumber = 1;
    while (num > 0)
    {
        res = res + num % 2 * countNumber;
        countNumber *= 10;
        num /= 2;
    }
    return res;
}

Console.WriteLine("Введите целое число:");
int number = Convert.ToInt32(Console.ReadLine());
int result = DecToBin(number);
Console.WriteLine($"Двоичное число:{result}");