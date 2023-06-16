// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int Prompt()
{
    Console.Write("Input num: ");
    int num = Convert.ToInt32(Console.ReadLine());

    return num;
}

bool ValidateDayNum(int dayNum)
{
    bool isDayValid = false;

    if(dayNum > 0 && dayNum < 8)
    {
        isDayValid = true;
    }

    return isDayValid;
}

int number = Prompt();

if(ValidateDayNum(number))
{
    if(number == 6 || number == 7)
    {
        System.Console.WriteLine("Выходной!");
    } else {
        System.Console.WriteLine("ТрудовыеБудни");
    }
} else{
    System.Console.WriteLine("Нет такого дня недели!");
}
