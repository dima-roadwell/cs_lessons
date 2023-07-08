// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

void PrintRange(int m, int n, int sum)
{
    if(m == n + 1)
    {
        System.Console.WriteLine(sum);
        return;
    }

    sum += m;
    
    m++;
    PrintRange(m, n, sum);
}

void Main()
{
    System.Console.Write("Input m: ");
    int m = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Input n: ");
    int n = Convert.ToInt32(Console.ReadLine());

    int sum = 0;

    

    PrintRange(m, n, sum);

    System.Console.WriteLine();
}

Main();