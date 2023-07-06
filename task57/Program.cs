

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
    int min = matrix[0, 0];
    int max = matrix[0, 0];

    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            if(min > matrix[i, j])
            {
                min = matrix[i, j];
            }

            if(max < matrix[i, j])
            {
                max = matrix[i, j];
            }
        }
    }

    for(int k = min; k < max + 1; k++)
    {
        int count = 0;

        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            for(int j = 0; j < matrix.GetLength(1); j++)
            {
                if(k == matrix[i, j])
                {
                    count++;
                }
            }
        }

        if(count > 0)
        {
            System.Console.WriteLine($"{k} встречается {count} раз");
        }
    }

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

void Main()
{
    System.Console.Write("Input m: ");
    int m = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Input n: ");
    int n = Convert.ToInt32(Console.ReadLine());

    int[,] matrix = FillArray(m, n);

    PrintMatrix(matrix);
    System.Console.WriteLine();
    Print(matrix);
}

Main();
