// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

//Метод приёма данных с консоли
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
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

//метод сортировки пузырьком
void BubbleSort(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        for (int j = 0; j < arr.Length - i - 1; j++)
        {
            if (arr[j] < arr[j + 1])
            {
                int temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
            }
        }
    }
}
//Метод перебора сторк массива и их сортировка
void Sort2DArrey(int[,] arr)
{
    int[] row = new int[arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {

        for (int j = 0; j < row.Length; j++)
        {
            row[j] = arr[i, j];
        }
        BubbleSort(row);
        for (int j = 0; j < row.Length; j++)
        {
            arr[i, j] = row[j];
        }

    }
}

int m = ReadData("Введите количество строк: ");
int n = ReadData("Введите количество столбцов: ");
int[,] matrix = new int[m, n];
Gen2DArray(matrix, 1, 100);
Print2DArr(matrix);
Console.WriteLine();
Sort2DArrey(matrix);
Print2DArr(matrix);

