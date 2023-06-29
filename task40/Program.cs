// Задача 40: Напишите программу, которая принимает на вход три числа и 
// проверяет, может ли существовать треугольник со сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

int[] CreateArray(int countArrElems)
{
    int[] numArr = new int[countArrElems];

    for(int i = 0; i < countArrElems; i++)
    {
        System.Console.Write($"Input num {i + 1}: ");
        numArr[i] = Convert.ToInt32(Console.ReadLine());
    }

    return numArr;
}

bool CheckSide(int[] sideArr)
{
    if(sideArr[0] < sideArr[1] + sideArr[2] && sideArr[1] < sideArr[0] + sideArr[2] && sideArr[2] < sideArr[0] + sideArr[1])
    {
        return true;
    } else {
        return false;
    }
}

void Print(bool check)
{
    System.Console.WriteLine(check);
}

void Main()
{
    int[] arr = CreateArray(3);

    Print(CheckSide(arr));
}

Main();
