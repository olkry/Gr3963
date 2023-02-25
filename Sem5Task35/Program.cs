// Задайте одномерный массив из 123 случайных
// чисел. Найдите количество элементов массива,
// значения которых лежат в отрезке [10,99].

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

void PrintData(string res, int value)
{
    Console.WriteLine(res + value);
}

int NumElemInRange(int[] arr, int minValue, int maxValue)
{
    int res = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if ((arr[i] > minValue) && (arr[i] < maxValue))
        {
            res++;
        }
    }
    return res;
}

int[] arrey = Gen1d1DArr(123, 0, 200);
Print1DArr(arrey);
int numberElem = NumElemInRange(arrey, 10, 99);
PrintData("Колличество элементов в диапазоне = ", numberElem);