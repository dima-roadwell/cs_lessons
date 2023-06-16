// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Input num: ");
int num = Convert.ToInt32(Console.ReadLine());

int outputNum = num / 10 % 10;

System.Console.WriteLine($"{outputNum}");
