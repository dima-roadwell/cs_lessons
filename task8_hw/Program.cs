// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Input num: ");
int num = Convert.ToInt32(Console.ReadLine());

int count = 2;

while(count <= num)
{
    System.Console.Write($"{count} "); 

    count += 2;
}

System.Console.WriteLine(); // Терминал (возможно линуксовый bash) выводит после выполнения строку ввода команды в той же строке, где были числа