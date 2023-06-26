// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateArray(int countArrElems)
{
    Random rnd = new Random();

    int[] numArr = new int[countArrElems];

    for(int i = 0; i < countArrElems; i++)
    {
        numArr[i] = rnd.Next(-1000, 1000);
    }

    return numArr;
}

string[] SumOddElements(int[] numArr)
{
    string[] arrayInfo = new string[2];

    int sum = 0;

    for(int i = 0; i < numArr.Length; i++)
    {
        if(i % 2 != 0)
        {
            sum += numArr[i];
        }

        arrayInfo[0] += numArr[i] + " ";
    }

    arrayInfo[1] = sum.ToString();

    return arrayInfo;
}

void Print(string[] arrInfo)
{
    System.Console.WriteLine("Array: " + arrInfo[0] + "\nSum odd numbers: " + arrInfo[1]);
}

void Main()
{
    int[] arr = CreateArray(8);

    Print(SumOddElements(arr));
}

Main();