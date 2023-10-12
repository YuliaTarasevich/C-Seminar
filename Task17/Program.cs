// Напишите программу, 
// 1.которая принимает на вход координаты точки (X и Y), 
// 2.причем X и Y не равны 0 и 
// 3.выдает номер четверти плоскости, в которой находится эта точка.

Console.WriteLine("Введите координаты точки");
Console.Write("X:");
int xCoordinate = Convert.ToInt32(Console.ReadLine());

Console.Write("Y:");
int yCoordinate = Convert.ToInt32(Console.ReadLine());

int Quarter(int x, int y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;
    return 0;
}

int quarter = Quarter(xCoordinate, yCoordinate);
string result = quarter > 0
                ? $"Указанные координаты соответствуют четверти => {quarter}"
                : "Введены неверные координаты";

Console.WriteLine(result);