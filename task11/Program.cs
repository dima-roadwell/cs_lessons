// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98



int DigitCrop(int num)
{
    int d1 = num / 100;
    int d3 = num % 10;

    return d1 * 10 + d3;
}

int number = new Random().Next(100, 1000);


System.Console.WriteLine($"{number} => {DigitCrop(number)}");

