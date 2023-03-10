// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
//Метод нахождения произведения 2х матриц. Просто перепишем 1ю принимаемую матрицу.
void ProductTwoArrays(int[,] arr1, int[,] arr2)
{
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr1.GetLength(1); j++)
        {
            arr1[i, j] = arr1[i, j] * arr2[i, j];
        }
    }
}
//Для упрощения задачи введём количество строк и столбцов матриц волшебными.
//Матрицы должны иметь одинаковое колличество индексов в строках и столбцах.
int[,] matrix1 = new int[4, 4];
int[,] matrix2 = new int[4, 4];
Gen2DArray(matrix1, 1, 999);
Console.WriteLine("Имеем 2 равноэлементные матрицы.");
Print2DArr(matrix1);
Console.WriteLine();
Gen2DArray(matrix2, 1, 999);
Print2DArr(matrix2);
Console.WriteLine();
Console.WriteLine("Произведением этих матриц будет:");
ProductTwoArrays(matrix1, matrix2);
Print2DArr(matrix1);