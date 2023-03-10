// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

//Метод приёма данных с консоли
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
//Метод выведения сообщения в консоль
void PrintData(string msg)
{
    Console.WriteLine(msg);
}
//генерация 2мерного массива приёмом массива
void Gen2DArray(int[,] matr, int min, int max)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(min, max + 1);
        }
    }
}
// Вывод 2мерного массива 
void Print2DArr(int[,] arr)
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}
//Метод нахождения страки с минимальной суммой
int MinRowCount(int[,] arr)
{
    int index = -1;
    int min = int.MaxValue;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum = sum + arr[i, j];
        }
        if (sum < min)
        {
            min = sum;
            index = i + 1;
        }
    }
    return index;
}

int m = ReadData("Введите количество строк: ");
int n = ReadData("Введите количество столбцов: ");
int[,] matrix = new int[m, n];
Gen2DArray(matrix, 1, 100);
Print2DArr(matrix);
Console.WriteLine();
PrintData($"Минимальная сумма чисел в {MinRowCount(matrix)}ой строке выведенного выше массива.");
