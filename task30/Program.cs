// Задача 30: Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int FillArray()
{
    int rndNum = new Random().Next(0, 2);

    return rndNum;
}

int[] arr = new int[8];

for(int i = 0; i < arr.Length; i++)
{
    arr[i] = FillArray();
    System.Console.Write(arr[i] + " ");
}