﻿// 16Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

System.Console.Write("Input Num1: ");
int num1 = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Input Num2: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 * num1 == num2 || num2 * num2 == num1)
{
    System.Console.WriteLine($"{num1}, {num2} -> true");
} else {
    System.Console.WriteLine($"{num1}, {num2} -> false");
}
