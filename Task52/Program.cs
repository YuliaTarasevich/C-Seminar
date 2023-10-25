// Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],7} ");
        }
        Console.WriteLine();
    }
}

double[] AverageColumn(int[,] matrix)
{
    int countColumns = matrix.GetLength(1);
    int countRows = matrix.GetLength(0);
    double[] arrAverage = new double[countColumns];
    for (int j = 0; j < countColumns; j++)
    {
        double sum = 0;
        double aver = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum = sum + matrix[i, j];
            aver = sum / countRows;
        }
        arrAverage[j] = Math.Round(aver, 2);
    }
    return arrAverage;
}


void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i],7} ");
    }
}

Console.WriteLine("Введите количество строк в массиве:");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов в массиве:");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите минимальное число в массиве в массиве:");
int minimum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите максимальное число в массиве:");
int maximum = Convert.ToInt32(Console.ReadLine());



int[,] array2d = CreateMatrixRndInt(m, n, minimum, maximum);
PrintMatrix(array2d);
double[] arrayNew = AverageColumn(array2d);
Console.WriteLine($"Среднее арифметическое каждого столбца:");
PrintArray(arrayNew);
