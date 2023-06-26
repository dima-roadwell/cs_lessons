// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] CreateArray(int countArrElems)
{
    double[] numArr = new double[countArrElems];

    for(int i = 0; i < countArrElems; i++)
    {
        System.Console.Write($"Input num {i + 1}: ");
        numArr[i] = Convert.ToDouble(Console.ReadLine());
    }

    return numArr;
}

double SearchMaxValue(double[] numArr)
{
    double max = numArr[0];

    for(int i = 1; i < numArr.Length; i++)
    {
        if(max < numArr[i])
        {
            max = numArr[i];
        }
    }

    return max;
}

double SearchMinValue(double[] numArr)
{
    double min = numArr[0];

    for(int i = 1; i < numArr.Length; i++)
    {
        if(min > numArr[i])
        {
            min = numArr[i];
        }
    }

    return min;
}

string[] GetArrInfo(double[] numArr, double numMin, double numMax)
{
    string[] arrayInfo = new string[4];

    for(int i = 0; i < numArr.Length; i++)
    {
        arrayInfo[0] += numArr[i] + " ";
    }

    arrayInfo[1] = numMin.ToString();
    arrayInfo[2] = numMax.ToString();

    arrayInfo[3] = MinMaxDifference(numMin, numMax).ToString();

    return arrayInfo;
}

double MinMaxDifference(double min, double max)
{
    double diff = max - min;

    return diff;
}

void Print(string[] arrInfo)
{
    System.Console.WriteLine("\nArray: " + arrInfo[0] + "\nMin num: " + arrInfo[1] + "\nMax num: " + arrInfo[2] + "\nDifference: " + arrInfo[3]);
}

void Main()
{
    double[] arr = CreateArray(5);

    double max = SearchMaxValue(arr);
    double min = SearchMinValue(arr);

    Print(GetArrInfo(arr, min, max));
}

Main();