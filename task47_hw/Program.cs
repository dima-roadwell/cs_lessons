// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
double[,] FillArray(int m, int n)
{
    double[,] matrix = new double[m, n];
    Random rnd = new Random();

    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            matrix[i, j] = Math.Round(rnd.Next(-10, 10) + rnd.NextDouble(), 2);
        }
    }

    return matrix;
}

void Print(double[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

void Main()
{
    System.Console.Write("Input m: ");
    int m = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Input n: ");
    int n = Convert.ToInt32(Console.ReadLine());

    double[,] matrix = FillArray(m, n);

    Print(FillArray(m, n));
}

Main();