// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min;
    }
    return arr;
}

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{Math.Round(arr[i], 1, MidpointRounding.ToZero)}; ");
        else Console.Write($"{Math.Round(arr[i], 1, MidpointRounding.ToZero)} ");
    }
}

double Min(double[] arr)
{
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
        }
    }
    return min;
}

double Max(double[] arr)
{
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
    }
    return max;
}

double Difference(double min, double max)
{
    double difference = max - min;
    return difference;
}

double[] array = CreateArrayRndDouble(3, 5, 89);
double minNumber = Min(array);
double maxNumber = Max(array);
double result = Difference(minNumber, maxNumber);
Console.Write("[");
PrintArray(array);
Console.Write($"] -> {Math.Round(result, 1)}");