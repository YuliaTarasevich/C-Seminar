// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

void ArrayFromKeyboard(out int[] args)
{

    Console.WriteLine("Введите число элементов массива");
    int elementsCount = Convert.ToInt32(Console.ReadLine());
    int[] arr = new int[elementsCount];
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"Введите элемент массива под индексом {i}");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    args=arr;

    Console.WriteLine("Вывод массива");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

int CountPositiveElements(int[] arr)
{
    int count = 0;   
    for (int i = 0; i < arr.Length; i++)
    {
        
        if (arr[i] > 0)
        count = count + 1;
    }
    return count;
}

int[] array;
ArrayFromKeyboard(out array);
Console.WriteLine();
int result = CountPositiveElements(array);
Console.WriteLine($"Количество элементов в введенном массиве больше нуля равно {result}");