// Напишите программу, 
// 1. которая принимает на вход координаты двух точек и 
// 2. находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты первой точки");
Console.Write("x1:");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("y1:");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("z1:");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки");
Console.Write("x2:");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("y2:");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("z2:");
int z2 = Convert.ToInt32(Console.ReadLine());

double distancePoints(int X1, int Y1, int X2, int Y2, int Z1, int Z2)
{
    double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    return result;
}

double Result = distancePoints(x1, x2, y1, y2, z1, z2);
Console.WriteLine($"Расстоние между заданными точками = {Math.Round(Result, 2, MidpointRounding.ToZero)}");
