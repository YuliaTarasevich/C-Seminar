// Напишите программу, 
// которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента 
// или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

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
            Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine();
    }
}

int SpecifiedElem(int[,] matrix, int rowPos, int columnPos)
{
    int specElem = 0;
    if (rowPos < matrix.GetLength(0) && columnPos < matrix.GetLength(1))
    {
        specElem = matrix[rowPos, columnPos];
    }
    return specElem;
}

Console.WriteLine("Введите количество строк в массиве:");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов в массиве:");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите минимальное число в массиве в массиве:");
int minimum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите максимальное число в массиве:");
int maximum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите позицию элемента массива в строке:");
int r = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите позицию элемента массива в столбце:");
int c = Convert.ToInt32(Console.ReadLine());

int[,] array2d = CreateMatrixRndInt(m, n, minimum, maximum);
PrintMatrix(array2d);
if (r < array2d.GetLength(0) && c < array2d.GetLength(1))
{
    int specElem = SpecifiedElem(array2d, r, c);
    Console.WriteLine($"Элемент с координатами ({r},{c}): {specElem}");
}
else
{
    Console.WriteLine("Указанные координаты выходят за границы массива");
}
