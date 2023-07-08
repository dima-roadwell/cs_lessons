// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void PrintRange(int n)
{
    if(n == 0)
    {
        return;
    }

    System.Console.Write($"{n} ");
    n--;
    PrintRange(n);
}

void Main()
{
    System.Console.Write("Input n: ");
    int n = Convert.ToInt32(Console.ReadLine());

    PrintRange(n);

    System.Console.WriteLine();
}

Main();