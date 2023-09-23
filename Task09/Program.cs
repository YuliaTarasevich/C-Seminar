// Напишите программу, которая 
// 1.выводит случайное число из отрезка [10, 99] и 
// 2. показывает наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8
int numberRandom1 = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка [10,99] => {numberRandom1}");

int numberRandom2 = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка [10,99] => {numberRandom2}");

// int remainder = numberRandom % 10;
// int quotient = numberRandom / 10;
// if (remainder > quotient)
// {
//     Console.WriteLine(remainder);
// }
// else
// {
//     Console.WriteLine(quotient);
// }
// int maxDigit = quotient > remainder ? quotient : remainder;
// Console.WriteLine(maxDigit);
// Math.Max(remainder,quotient);

int maxDigit1 = MaxDigit(numberRandom1);
Console.WriteLine($"Наибольшая цифра числа => {maxDigit1}");

int maxDigit2 = MaxDigit(numberRandom2);
Console.WriteLine($"Наибольшая цифра числа => {maxDigit2}");

int MaxDigit(int numRandom) // numRandom = numberRandom
{
    int remainder = numRandom % 10;
    int quotient = numRandom / 10;
    int maxDigit = quotient > remainder ? quotient : remainder;
    return maxDigit;
}