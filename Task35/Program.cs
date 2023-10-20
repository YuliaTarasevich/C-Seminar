// Задайте одномерный массив из 123 случайных чисел.
// Найдите количесвто элементов массива,
// значения которых лежат в отрезке [10, 99].
// [5, 18, 123, 6, 2] -> 1


int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]} ");
    }
}

int CountElem(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= 10 && arr[i] < 100)
        {
            count ++;
        }
    }
    return count;
}

int [] array = CreateArrayRndInt (123, 1, 100);
Console.Write("[");
PrintArray(array);
Console.WriteLine("] ->");
int result = CountElem (array);
Console.Write(result);