// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int[] Prompt(int countNum)
{
    int[] num = new int[countNum];

    for(int i = 1; i <= countNum; i++)
    {
        System.Console.Write($"Input Num {i}: ");
        num[i - 1] = Convert.ToInt32(Console.ReadLine());
    }

    return num;
}

int Pow(int[] numbers)
{
    int pow = 1;

    for(int i = 1; i <= numbers[1]; i++)
    {
        pow *= numbers[0];
    }

    return pow;
}

void Print(int num)
{
    System.Console.WriteLine(num);
}

void Main()
{
    int[] numberArr = Prompt(2);

    int pow = Pow(numberArr);

    Print(pow);
}

Main();
