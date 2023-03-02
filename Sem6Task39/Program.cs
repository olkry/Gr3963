// Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на
// первом месте, а первый - на последнем и т.д.) 2 метода.


int[] GenArray(int len, int min, int max)
{
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(min, max + 1);
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
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

//Метод замены элементов в массиве.
void SwapArrey(int[] arr)
{
    int bufElem = 0;
    for (int i = 0; i < arr.Length / 2; i++)
    {
        bufElem = arr[i];
        arr[i] = arr[arr.Length - 1 - i];
        arr[arr.Length - 1 - i] = bufElem;
    }
}

//Метод создания нового и заполнением с конца входящего.
int[] NewSwapArrey(int[] arr)
{
    int[] outArr = new int[arr.Length];
    for (int i = 0; i < outArr.Length; i++)
    {
        outArr[i] = arr[arr.Length - i - 1];
    }
    return outArr;
}

int[] testArrey = GenArray(123, 10, 100);
Print1DArr(testArrey);
Console.WriteLine();
//SwapArrey(testArrey);
int[] newArrey = NewSwapArrey(testArrey);
Print1DArr(testArrey);
Console.WriteLine();
Print1DArr(newArrey);