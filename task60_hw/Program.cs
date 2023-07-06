// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] FillArray(int m, int n, int l)
{
    Random rnd = new Random();
    int num = rnd.Next(10, 100);
    
    int[] usedNum = new int[m * n * l];
    usedNum[0] = num;
    

    int[,,] matrix = new int[m, n, l];
    

    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            for(int k = 0; k < l; k++)
            {
                num = RandomizeNonRecurringNum(num, usedNum, rnd);

                for(int o = 0; o < usedNum.Length; o++)
                {
                    if(usedNum[o] == 0)
                    {
                        usedNum[o] = num;
                        break;
                    }
                }

                matrix[i, j, k] = num;
            }
        }
    }

    return matrix;
}

int RandomizeNonRecurringNum(int num, int[] usedNum, Random rand)
{
    for(int i = 0; i < usedNum.Length; i++)
    {
        if(num == usedNum[i])
        {
            num = rand.Next(10, 100);
            RandomizeNonRecurringNum(num, usedNum, rand);
        }
    }

    return num;
}

void Print(int[,,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            for(int k = 0; k < matrix.GetLength(2); k++)
            {
                System.Console.Write($"{matrix[i, j, k]}({i},{j},{k})\t");
            }
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
    System.Console.Write("Input l: ");
    int l = Convert.ToInt32(Console.ReadLine());

    if(m * n * l < 100)
    {
        int[,,] matrix = FillArray(m, n, l);

        Print(matrix);
    } else {
        System.Console.WriteLine("Нет такого количества двузначных чисел");
    }
}

Main();
