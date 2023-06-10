// Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 
// a = -3 b = 9 -> нет

Console.Write("Input num A: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Input num B: ");
int b = Convert.ToInt32(Console.ReadLine());

int quarter = b * b;

if(a == quarter)
{
    Console.WriteLine("True");
} else {
    Console.WriteLine("False");
}