// Найдите произведение пар чисел  в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3  
// [6 7 3 6] -> 36 21


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

int[] NewArray(int[] arr)
{
    int[] newArray = new int[(arr.Length + 1) / 2];
    for (int i = 0; i < (arr.Length + 1) / 2; i++)
    {
        if (i != arr.Length - 1 - i) // добавленная проверка для нечетного количества элементов
        {
            newArray[i] = arr[i] * arr[arr.Length - 1 - i];
        }
        else
        {
            newArray[i] = arr[i]; // добавление последнего элемента
        }
    }
    return newArray;
}

int[] massive = CreateArrayRndInt(5, 1, 9);
Console.Write("[");
PrintArray(massive);
Console.Write("] --> ");
int[] newmassive = NewArray(massive);
PrintArray(newmassive);