// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int Prompt()
{
    System.Console.Write("Input count: ");
    int count = Convert.ToInt32(Console.ReadLine());

    int num = 0;
    int countPositiveNum = 0;

    for(int i = 0; i < count; i++)
    {
        System.Console.Write($"Input num {i + 1}: ");
        num = Convert.ToInt32(Console.ReadLine());

        if(num > 0)
        {
            countPositiveNum++;
        }
    }

    return countPositiveNum;
}

void Print(int count)
{
    System.Console.WriteLine($"Количество положительных чисел: {count}");
}

void Main()
{
    Print(Prompt());
}

Main();