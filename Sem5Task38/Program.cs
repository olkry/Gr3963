// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

//метод генерации массива для вещественных чисел
double[] Gen1d1DArr(int len, int min, int max)
{
    Random rnd = new Random();
    double[] arr = new double[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = (double)rnd.Next(min, max + 1);
    }
    return arr;
}

//метод печати массива
void Print1DArr(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.Write(arr[arr.Length - 1]);
    Console.WriteLine("]");
}
// Метод нахождения и вычитания 
double MaxMin(double[] arr)
{
    double min = double.MaxValue;
    double max = double.MinValue;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
        if (arr[i] < min) min = arr[i];
    }
    return (max - min);
}

double[] array = Gen1d1DArr(10, -9, 9);
Print1DArr(array);
Console.WriteLine(MaxMin(array));
