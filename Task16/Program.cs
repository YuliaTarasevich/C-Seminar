// Напишите программу, которая
// 1. принимает на вход два числа и 
// 2. проверяет, является ли одно квадратом другого.
// 25, 5 --> да
// 5, 25 --> да
// 25, 6 --> нет
Console.WriteLine("Введите первое число");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int secondNumber = Convert.ToInt32(Console.ReadLine());

bool result = CheckSquare(firstNumber, secondNumber);
Console.WriteLine(result ? "Да" : "Нет");

bool CheckSquare(int firstNum, int secondNum)
{
    return firstNum == secondNum * secondNum || secondNum == firstNum * firstNum;
}