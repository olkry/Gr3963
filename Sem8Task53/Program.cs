// Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю
// строку массива.

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
//Метод замены 1ой и последней строки местамию
void Chenge2DArray(int[,] matr)
{
    int temp = 0;
    for (int i = 0; i < matr.GetLength(1); i++)
    {
        //(matr[0,1],matr[matr.GetLength(0)-1,i])=(matr[matr.GetLength(0)-1,i]);
        temp = matr[0, i];
        matr[0, i] = matr[matr.GetLength(0) - 1, i];
        matr[matr.GetLength(0) - 1, i] = temp;
    }
}
int m = ReadData("Введите количество строк: ");
int n = ReadData("Введите количество столбцов: ");
int[,] matrix = new int[m, n];
Gen2DArray(matrix,1,100);
Print2DArr(matrix);
Console.WriteLine();
Chenge2DArray(matrix);
Print2DArr(matrix);
