// Напишите программу, которая
// 1. принимает на вход координаты двух точек и
// 2. находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координаты первой точки");
Console.Write("x1:");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("y1:");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки");
Console.Write("x2:");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("y2:");
int y2 = Convert.ToInt32(Console.ReadLine());

double Result = distancePoints(x1, x2, y1, y2);
Console.WriteLine($"Расстоние между заданными точками = {Math.Round(Result,2,MidpointRounding.ToZero)}");

double distancePoints(int X1, int Y1, int X2, int Y2)
{
    double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    return result;
}
