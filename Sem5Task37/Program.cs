// Найдите произведение пар чисел в одномерном
// массиве. Парой считаем первый и последний
// элемент, второй и предпоследний и т.д. Результат
// запишите в новом массиве.

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

int[] ConvertArr(int[] arr)
{
    int len = arr.Length / 2;
    if (arr.Length % 2 == 1)
    {
        len = len + 1;
    }

    int[] bufArr = new int[len];
    for (int i = 0; i < len; i++)
    {
        bufArr[i] = arr[i] * arr[arr.Length - 1 - i];
    }
    return bufArr;
}

int[] arrey = Gen1d1DArr(5, 1, 5);
Print1DArr(arrey);
Print1DArr(ConvertArr(arrey));