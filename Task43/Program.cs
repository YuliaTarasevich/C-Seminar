// Напишите программу, 
// которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void IntersectionPoint(double b01, double k01, double b02, double k02)
{
    double xCoordinate = (b02 - b01) / (k01 - k02);
    double yCoordinate = k01 * xCoordinate + b01;
    Console.WriteLine($"{Math.Round(xCoordinate,2)};{Math.Round(yCoordinate,2)}");
}
Console.WriteLine("Введите коэффициент b1:");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите коэффициент k1:");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите коэффициент b2:");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите коэффициент k2:");
double k2 = Convert.ToDouble(Console.ReadLine());

IntersectionPoint(b1, k1, b2, k2);