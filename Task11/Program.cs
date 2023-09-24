// Напишите программу, которая
// 1. выводит случайное трехзначное число и 
// 2. удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
int numberRandom = new Random().Next(100, 1000);
Console.WriteLine($"Случайное трехзначное число = {numberRandom}");

int result = DeleteSecondDigit(numberRandom);
Console.WriteLine($"Итоговое число равно {result}");

int DeleteSecondDigit(int numRandom)
{
    int quotient = numRandom / 100;
    int remainder = numRandom % 10;
    int deleteSecondDigit = quotient * 10 + remainder;
    return deleteSecondDigit;
}