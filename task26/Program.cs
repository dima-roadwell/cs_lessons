// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int CheckDigitCount(int number)
{
    string numberStr = number.ToString();
    char[] numberArr = numberStr.ToCharArray();
    int countDigit = numberArr.Length;

    return countDigit;
}

System.Console.Write("Input Num: ");
int num = Convert.ToInt32(Console.ReadLine());
int numCount = CheckDigitCount(num);

System.Console.WriteLine($"Количество чисел - {numCount}");