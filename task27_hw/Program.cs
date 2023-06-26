// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Prompt()
{
    System.Console.Write("Input Num: ");
    int num = Convert.ToInt32(Console.ReadLine());

    return num;
}

void Print(int num)
{
    System.Console.WriteLine(num);
}

int SumDigit(int number)
{
    int sum = 0;
    string numStr = number.ToString();

    for(int i = 0; i < numStr.Length; i++)
    {
        sum += number % 10;
        number /= 10;
    }

    // while(number > 99)
    // {
    //     number %=  10;
    //     sum += number;
    // }

    return sum;
}

void Main()
{
    int number = Prompt();

    Print(SumDigit(number));
}

Main();