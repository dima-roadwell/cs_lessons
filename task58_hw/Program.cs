// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] ProductMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] newMatrix = new int[matrix1.GetLength(0), matrix1.GetLength(1)];

    for(int i = 0; i < matrix1.GetLength(0); i++)
    {
        for(int j = 0; j < matrix1.GetLength(1); j++)
        {
            int sum = 0;

            for(int k = 0; k < matrix1.GetLength(1); k++)
            {
                sum += matrix1[i, k] * matrix2[k, j];
            }

            newMatrix[i, j] = sum;
        }
    }

    return newMatrix;
}

void Main()
{
    System.Console.Write("Input m1: ");
    int m1 = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Input n1: ");
    int n1 = Convert.ToInt32(Console.ReadLine());

    System.Console.Write("Input m2: ");
    int m2 = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Input n2: ");
    int n2 = Convert.ToInt32(Console.ReadLine());

    if(m1 != n2 || n1 != m2)
    {
        System.Console.WriteLine("Количество столбцов первой матрицы должно быть равно количеству строк второй матрицы!");
    } else {
        int[,] matrix1 = FillArray(m1, n1);
        int[,] matrix2 = FillArray(m2, n2);

        Print(matrix1);
        System.Console.WriteLine();
        Print(matrix2);
        System.Console.WriteLine();
        Print(ProductMatrix(matrix1, matrix2));


    }
}

Main();
