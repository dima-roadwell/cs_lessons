// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] CreateArray(int countArrElems)
{
    int[] numArr = new int[countArrElems];

    for(int i = 0; i < countArrElems; i++)
    {
        numArr[i] = new Random().Next(0, 1000);
    }

    return numArr;
}

void Print(int[] numArr)
{
    for(int i = 0; i < numArr.Length; i++)
    {
        if(i == numArr.Length - 1)
        {
            System.Console.Write(numArr[i]);
        } else {
            System.Console.Write(numArr[i] + ", ");
        }
    }
}

void Main()
{
    int[] arr = CreateArray(8);

    Print(arr);
}

Main();