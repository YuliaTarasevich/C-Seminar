// Напишите программу, которая
// принимает на вход число (N) и 
// выдаёт произведение чисел от 1 до N.


Console.WriteLine("Введите целое положительное число");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0)
{
    int result = ProductsNumbers(number);
    Console.WriteLine(result);
}
else Console.WriteLine("Ошибка ввода, введите ПОЛОЖИТЕЛЬНОЕ ЧИСЛО");


int ProductsNumbers(int numBer)
{
    int product = 1;
    for (int i = 1; i <= numBer; i++)
    {
       checked {product = product * i;}
    }
    return product;
}
