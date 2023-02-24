// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.Write(arr[arr.Length - 1]);
    Console.WriteLine("]");
}

int[] Gen1d1DArr(int len, int min, int max)
{
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(min, max + 1);
    }
    return arr;
}

int length = ReadData("Введите длину массива");
int minNum = ReadData("Введите минимальное число массива");
int maxNum = ReadData("Введите максимальное число массива");

Print1DArr(Gen1d1DArr(length, minNum, maxNum));