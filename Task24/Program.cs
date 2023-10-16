// Напишите программу, которая
// принимает на вход число (А) и 
// выдаёт сумму чисел от 1 до А.

Console.WriteLine("Введите целое положительное число");
int number = Convert.ToInt32(Console.ReadLine());

int result = SummNumbers(number);
Console.WriteLine(result);

int SummNumbers(int numBer)
{
    int sum = 0;
for (int i = 1; i <= numBer; i++)
{
    sum = sum + i;
}
return sum;
}