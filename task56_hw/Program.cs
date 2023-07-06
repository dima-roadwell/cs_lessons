// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] FillArray(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();

    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            matrix[i, j] = rnd.Next(0, 10);
        }
    }

    return matrix;
}

void Print(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

void CalculateItems(int[,] matrix)
{
    int[] rowInfo = new int[2];
    int tmpSum = 0;

    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            tmpSum += matrix[i, j];
        }

        if(rowInfo[1] > tmpSum || i == 0)
        {
            rowInfo[0] = i;
            rowInfo[1] = tmpSum;
        }

        tmpSum = 0;
    }

    System.Console.WriteLine($"Наименьшая сумма эл-ов в строке с индексом - {rowInfo[0]}. Сумма эл-ов = {rowInfo[1]}");
}

void Main()
{
    System.Console.Write("Input m: ");
    int m = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Input n: ");
    int n = Convert.ToInt32(Console.ReadLine());

    int[,] matrix = FillArray(m, n);

    Print(matrix);
    CalculateItems(matrix);
}

Main();
