// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Input num A: ");
int numA = Convert.ToInt32(Console.ReadLine());

Console.Write("Input num B: ");
int numB = Convert.ToInt32(Console.ReadLine());

if(numA > numB)
{
    System.Console.WriteLine($"Число A ({numA}) больше числа B ({numB})");
} else if(numB > numA)
{
    System.Console.WriteLine($"Число B ({numB}) больше числа A ({numA})");
} else {
    System.Console.WriteLine("Числа равны");
}

