// Напишите программу,
// которая выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

void FillArray(int[] collection)
{
    Random num = new Random();
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = num.Next(0, 2);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    Console.Write("[");
    while (position < count)
    {
        if (position == col.Length - 1)
        {
            Console.Write($"{col[position]}");
        }

        else
        {
            Console.Write($"{col[position]}, ");
        }
        position++;
    }
     Console.Write("]");
}

int[] array = new int[8];

FillArray(array);
PrintArray(array);
