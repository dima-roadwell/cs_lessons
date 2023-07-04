// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

void PrintMatrix(int[,] matrix)
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

void MeanCalculate(int[,] matrix)
{
    double avg = 0;
    string output = "";

    for(int i = 0; i < matrix.GetLength(1); i++)
    {
        for(int j = 0; j < matrix.GetLength(0); j++)
        {
            avg += matrix[j, i];
        }
        
        avg = Math.Round(avg / matrix.GetLength(0), 2);

        output += $"Row {i} average = {avg}; ";
    }

    System.Console.WriteLine(output);
}

void Main()
{
    int[,] matrix = FillArray(4, 4);

    PrintMatrix(matrix);
    System.Console.WriteLine();
    MeanCalculate(matrix);
}

Main();