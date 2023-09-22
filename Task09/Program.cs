// Напишите программу, которая 
// 1.выводит случайное число из отрезка [10, 99] и 
// 2. показывает наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8
int numberRandom = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка [10,99] => {numberRandom}");
int remainder = numberRandom % 10;
int quotient = numberRandom / 10;
// if (remainder > quotient)
// {
//     Console.WriteLine(remainder);
// }
// else
// {
//     Console.WriteLine(quotient);
// }
int maxDigit = quotient > remainder ? quotient : remainder;
Console.WriteLine(maxDigit);