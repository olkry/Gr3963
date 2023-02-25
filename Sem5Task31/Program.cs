// Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных
// элементов массива.

// Генератор массива
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
//Вывод массива
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
// Расчёт суммы максимальных и минимальных значений массива
(int posit, int negot) NegPosSum(int[] arr)
{
    int positSum = 0;
    int negotSum = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            positSum += arr[i];
        }
        else
        {
            negotSum += arr[i];
        }
    }
    return (positSum, negotSum);
}

int[] testArr = Gen1d1DArr(12, 9, -9);
Print1DArr(testArr);
(int posit, int negot) results = NegPosSum(testArr);
PrintData("Сумма положительных чисел: ", results.posit);
PrintData("Сумма отрицательных чисел: ", results.negot);