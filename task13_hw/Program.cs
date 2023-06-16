// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int Prompt()
{
    Console.Write("Input num: ");
    int num = Convert.ToInt32(Console.ReadLine());

    return num;
}

bool CheckThreeDigit(int number)
{
    bool isThreeDigit = false;

    if(number > 99)
    {
        isThreeDigit = true;
    }

    return isThreeDigit;
}

char ShowThirdDigit(int num)
{
    char[] numArr = num.ToString().ToCharArray();

    return numArr[2];
}

int number = Prompt();
bool isThirdNumber = CheckThreeDigit(number);

if(isThirdNumber)
{
    System.Console.WriteLine(ShowThirdDigit(number));
} else {
    System.Console.WriteLine("Третьей цифры нет");
}