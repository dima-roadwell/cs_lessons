// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] CreateArray(int countArrElems)
{
    int[] numArr = new int[countArrElems];

    for(int i = 0; i < countArrElems; i++)
    {
        numArr[i] = new Random().Next(100, 1000);
    }

    return numArr;
}

string[] ShowEvenNum(int[] numArr)
{
    string[] arrayInfo = new string[2];

    int countEvenNum = 0;

    for(int i = 0; i < numArr.Length; i++)
    {
        if(numArr[i] % 2 == 0)
        {
            countEvenNum++;
        }

        arrayInfo[0] += numArr[i] + " ";
    }

    arrayInfo[1] = countEvenNum.ToString();

    return arrayInfo;
}

void Print(string[] arrInfo)
{
    System.Console.WriteLine("Array: " + arrInfo[0] + "\nEven Numbers: " + arrInfo[1]);
}


void Main()
{
    int[] arr = CreateArray(8);

    Print(ShowEvenNum(arr));
}

Main();
