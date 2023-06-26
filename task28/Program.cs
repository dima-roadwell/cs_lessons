// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120\

int Product(int number)
{
    int product = 1;

    for(int i = 1; i <= number; i++)
    {
        product *= i;
    }

    return product;
}

System.Console.Write("Input Num: ");
int num = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"Произведение числе от 1 до {num} = {Product(num)}");

