// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
int[,] FillArray(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();

    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            matrix[i, j] = rnd.Next(-10, 10);
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

void Print(int pos, int[,] matrix)
{
    int row = pos / 10;
    int column = pos % 10;

    if(row >= 0
        && row < matrix.GetLength(0)
        && column >= 0
        && column < matrix.GetLength(1))
    {
        System.Console.WriteLine(matrix[row, column]);
    } else {
        System.Console.WriteLine("Такой позиции в массиве не существует");
    }
}

void Main()
{
    int[,] matrix = FillArray(5, 7);

    System.Console.Write("Input position: ");
    int position = Convert.ToInt32(Console.ReadLine());

    PrintMatrix(matrix);
    System.Console.WriteLine();
    Print(position, matrix);
}

Main();
