// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

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

// Напечатать результат
void PrintData(string res, int value)
{
    Console.WriteLine(res + value);
}

//Метод подсчёта суммы нечётных чисел
int OddSum(int[] arr)
{
    int res = 0;
    for(int i = 0; i<arr.Length; i = i+2)
    {
        res = res+arr[i];
    }
    return res;
}

int[] arrey = Gen1d1DArr(99, -999, 999);
Print1DArr(arrey);
PrintData("Сумма всех эементов нечётных позиций = ", OddSum(arrey));