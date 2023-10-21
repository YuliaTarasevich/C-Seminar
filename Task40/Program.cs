// Напишите программу, которая 
// принимает на вход три числа и проверяет, 
// может ли существовать треугольник со сторонами такой длины.
// Теорема о неравенстве треугольника: 
// каждая сторона треугольника меньше суммы двух других сторон.

bool IsNumberBOk(int number)
{
    return  (number > 0);
}

bool IsTriangle(int num1, int num2, int num3)
{
    return (num1 + num2 > num3 && num2 + num3 > num1 && num1 + num3 > num2);
}

Console.WriteLine("Введите длины первой стороны треугольника:");
int firstSide = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длины второй стороны треугольника:");
int secondSide = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длины третьей стороны треугольника:");
int thirdSide = Convert.ToInt32(Console.ReadLine());

if (IsNumberBOk(firstSide) && IsNumberBOk(secondSide) && IsNumberBOk(thirdSide))
{
    Console.WriteLine (IsTriangle(firstSide, secondSide, thirdSide)?"Поздравляю, Ваш треугольник существует":"К сожалению, Вашего треугольника не существует");

}
else
{
    Console.WriteLine("Ошибка ввода. Введите целое положительное значение длины треугольника");
}