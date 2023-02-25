// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// + 1я* Сортировка Пузырьком.

//метод ввода числа
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
//метод генерации массива
int[] Gen1d1DArr(int len, int min, int max)
{
    // Блок корректировки входных данных
    if (min > max)
    {
        int buf = max;
        max = min;
        min = buf;
    }

    Random rnd = new Random();
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}
//метод печати массива
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
//метод подсчёта чётных чисел
int NumElemEvNum(int[] arr)
{
    int res = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            res++;
        }
    }
    return res;
}
//метод сортировки пузырьком
int[] BubbleSort(int[] arr)
{
    int temp = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[i] > arr[j])
            {
                temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
    }
    return arr;
}

int len = ReadData("Какую длину массива вы желаете?");
int min = ReadData("Минимальное трёхзначное число: ");
int max = ReadData("Максимальное трёхзначное число: ");
int[] arrey = Gen1d1DArr(len, min, max);
Console.WriteLine("Получаем с вами следующий массив: ");
Print1DArr(arrey);
Console.WriteLine("Отсортируем его пузырьком");
BubbleSort(arrey);
Print1DArr(arrey);
Console.WriteLine($"В данном массиве {NumElemEvNum(arrey)} четных чисел");