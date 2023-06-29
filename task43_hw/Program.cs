// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double Prompt(string pointName)
{
    System.Console.Write($"Input point {pointName}: ");
    double point = Convert.ToDouble(Console.ReadLine());

    return point;
}

double[] SearchIntersectionPoints(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    double[] coordsArr = new double[]{x, y};

    return coordsArr;
}

void Print(double[] coordsArray)
{
    System.Console.WriteLine($"Точка пересечения прямых: {coordsArray[0]}; {coordsArray[1]}");
}

void Main()
{
    double b1 = Prompt("B1");
    double k1 = Prompt("K1");

    double b2 = Prompt("B2");
    double k2 = Prompt("K2");

    Print(SearchIntersectionPoints(b1, k1, b2, k2));
}

Main();
