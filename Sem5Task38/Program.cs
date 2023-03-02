// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// //метод генерации массива для вещественных чисел
// double[] Gen1d1DArr(int len, int min, int max)
// {
//     Random rnd = new Random();
//     double[] arr = new double[len];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = (double)rnd.Next(min, max + 1);
//     }
//     return arr;
// }

// //метод печати массива
// void Print1DArr(double[] arr)
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length - 1; i++)
//     {
//         Console.Write(arr[i] + ", ");
//     }
//     Console.Write(arr[arr.Length - 1]);
//     Console.WriteLine("]");
// }
// // Метод нахождения и вычитания 
// double MaxMin(double[] arr)
// {
//     double min = double.MaxValue;
//     double max = double.MinValue;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] > max) max = arr[i];
//         if (arr[i] < min) min = arr[i];
//     }
//     return (max - min);
// }

// double[] array = Gen1d1DArr(10, -9, 9);
// Print1DArr(array);
// Console.WriteLine(MaxMin(array));

//Полное решение

//метод генерации вещественного массива
double[] GenArray(int len, int min, int max)
{
    double[] arr = new double[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(min, max + 1) + (new Random().NextDouble());
        //Округление до 4х цифр после запятой
        arr[i] = Math.Round(arr[i], 4);
    }
    return arr;
}

void Print1DArr(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

void BubbleSort(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        for (int j = i + 1; j < arr.Length - i - 1; j++)
        {
            if (arr[j] > arr[j + 1])
            {
                double temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
            }
        }
}

double[] testArrey = GenArray(123, 0, 50);
Print1DArr(testArrey);
BubbleSort(testArrey);
Print1DArr(testArrey);
Console.WriteLine(testArrey[testArrey.Length - 1] - testArrey[0]);
