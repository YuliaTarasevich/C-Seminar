﻿// Задайте массив.
// Напишите программу, которая определяет,
// присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

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

bool IsSetNumber (int [] arr, int num)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]==num)
        {
            return true;
        }
    }
    return false;
}

int [] array = CreateArrayRndInt (8, -5, 6);
Console.Write("[");
PrintArray(array);
Console.WriteLine("]");
Console.WriteLine("Введите число для поиска в массиве:");
int number = Convert.ToInt32(Console.ReadLine());
bool result=IsSetNumber(array, number);
Console.WriteLine(result?"Да":"Нет");