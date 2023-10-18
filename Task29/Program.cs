//  Напишите программу, 
//  которая задаёт массив из 8 элементов и 
//  выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 1, 33, 6]

int Prompt(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    int finish = Convert.ToInt32(value);
    return finish;
}

int [] GenerateArray (int Length, int minValue, int maxValue)
{
    int[]array = new int[Length];
    Random num = new Random();
    int index = 0;
    while (index < Length)
    {
        array[index] = num.Next(minValue,maxValue+1);
        index++;
    }
    return array;
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

int length = Prompt("Введите длину массива:");
int min = Prompt("Введите начальное значение, для диапазона массива:");
int max = Prompt("Введите конечное значение, для диапазона массива:");
int []array = GenerateArray(length,min,max);
Console.Write(string.Join(", ",array));
Console.Write(" --> ");
PrintArray(array);
