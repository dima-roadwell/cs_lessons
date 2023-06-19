// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double CalculateDistance3D(double aX, double aY, double aZ, double bX, double bY, double bZ)
{
    double distance = Math.Sqrt(Math.Pow(aX - bX, 2) + Math.Pow(aY - bY, 2) + Math.Pow(aZ - bZ, 2));

    return Math.Round(distance, 2);
}

double InputNum(string point)
{
    System.Console.Write($"Input {point}: ");
    double number = Convert.ToDouble(Console.ReadLine());

    return number;
}

void Print(double dist)
{
    System.Console.WriteLine($"Расстояние: {dist}");
}

double aX = InputNum("Ax");
double aY = InputNum("Ay");
double aZ = InputNum("Az");

double bX = InputNum("Bx");
double bY = InputNum("By");
double bZ = InputNum("Bz");

double distance = CalculateDistance3D(aX, aY, aZ, bX, bY, bZ);
Print(distance);