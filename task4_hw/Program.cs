// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Input num A: ");
int numA = Convert.ToInt32(Console.ReadLine());

Console.Write("Input num B: ");
int numB = Convert.ToInt32(Console.ReadLine());

Console.Write("Input num C: ");
int numC = Convert.ToInt32(Console.ReadLine());

int max = numA;

if(numB > max)
{
    max = numB;
} 

if(numC > max)
{
    max = numC;
}

System.Console.WriteLine(max);