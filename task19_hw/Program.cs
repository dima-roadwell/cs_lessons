// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int InputNum()
{
    System.Console.Write("Input Num: ");
    string? number = Console.ReadLine();

    if(int.TryParse(number, out int num))
    {
        return num;
    } else {
        InputNum();

        return 0;
    }
}

void Print(int number)
{
    string numberStr = number.ToString();
    char[] numberArr = numberStr.ToCharArray();
    Array.Reverse(numberArr);

    string numberStrRev = new string(numberArr);

    if(numberStr == numberStrRev)
    {
        System.Console.WriteLine($"{number} -> true");
    } else {
        System.Console.WriteLine($"{number} -> false");
    }
}


int num = InputNum();

Print(num);