// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int Prompt (string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int res=Convert.ToInt32(value);
    return res;
}

int[] ArrayFromKeyboard(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i]=Prompt($"Введите {i+1}-й элемент");
    }
    return array;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]} ");
    }
}

int CountPositiveElements(int[] arr)
{
    int count = 0;   
    for (int i = 0; i < arr.Length; i++)
    {
        
        if (arr[i] > 0)
        count++;
    }
    return count;
}

int length = Prompt("Введите количество элементов");
Console.WriteLine();
int[] array;
array = ArrayFromKeyboard(length);
PrintArray(array);
int result = CountPositiveElements(array);
Console.WriteLine($"Количество элементов в введенном массиве больше нуля равно {result}");