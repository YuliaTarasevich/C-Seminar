//  Напишите программу, 
//  которая задаёт массив из 8 элементов и 
//  выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 1, 33, 6]

void FillArray(int[] collection)
{
    Random num = new Random();
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = num.Next(0, 45);
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
Console.Write(string.Join(", ",array));
Console.Write(" --> ");
PrintArray(array);