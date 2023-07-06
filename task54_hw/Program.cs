// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] FillArray(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();

    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            matrix[i, j] = rnd.Next(0, 100);
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

int[,] RowsDesc(int[,] matrix)
{
    int tmp = matrix[0, 0];

    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            for(int k = j + 1; k < matrix.GetLength(1); k++)
            {
                if(k < matrix.GetLength(1) && matrix[i, j] < matrix[i, k])
                {
                    tmp = matrix[i, j];
                    matrix[i, j] = matrix[i, k];
                    matrix[i, k] = tmp;
                }
            }
        }
    }

    return matrix;
}

void Main()
{
    System.Console.Write("Input m: ");
    int m = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Input n: ");
    int n = Convert.ToInt32(Console.ReadLine());

    int[,] matrix = FillArray(m, n);

    Print(matrix);
    System.Console.WriteLine();
    Print(RowsDesc(matrix));
}

Main();
