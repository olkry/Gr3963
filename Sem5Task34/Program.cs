// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// + 1я* Сортировка Пузырьком.

// //метод ввода числа
// int ReadData(string msg)
// {
//     Console.WriteLine(msg);
//     return int.Parse(Console.ReadLine() ?? "0");
// }
// //метод генерации массива
// int[] Gen1d1DArr(int len, int min, int max)
// {
//     // Блок корректировки входных данных
//     if (min > max)
//     {
//         int buf = max;
//         max = min;
//         min = buf;
//     }

//     Random rnd = new Random();
//     int[] arr = new int[len];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rnd.Next(min, max + 1);
//     }
//     return arr;
// }
// //метод печати массива
// void Print1DArr(int[] arr)
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length - 1; i++)
//     {
//         Console.Write(arr[i] + ", ");
//     }
//     Console.Write(arr[arr.Length - 1]);
//     Console.WriteLine("]");
// }
// //метод подсчёта чётных чисел
// int NumElemEvNum(int[] arr)
// {
//     int res = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] % 2 == 0)
//         {
//             res++;
//         }
//     }
//     return res;
// }
// //метод сортировки пузырьком
// int[] BubbleSort(int[] arr)
// {
//     int temp = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         for (int j = i + 1; j < arr.Length; j++)
//         {
//             if (arr[i] > arr[j])
//             {
//                 temp = arr[i];
//                 arr[i] = arr[j];
//                 arr[j] = temp;
//             }
//         }
//     }
//     return arr;
// }

// int len = ReadData("Какую длину массива вы желаете?");
// int min = ReadData("Минимальное трёхзначное число: ");
// int max = ReadData("Максимальное трёхзначное число: ");
// int[] arrey = Gen1d1DArr(len, min, max);
// Console.WriteLine("Получаем с вами следующий массив: ");
// Print1DArr(arrey);
// Console.WriteLine("Отсортируем его пузырьком");
// BubbleSort(arrey);
// Print1DArr(arrey);
// Console.WriteLine($"В данном массиве {NumElemEvNum(arrey)} четных чисел");

//ещё вариант от преподавателя

//метод генерации массива
int[] GenArray(int len, int min, int max)
{
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(min, max + 1);
    }
    return arr;
}

//Метод выводящий данные пользователю
void PrintData(string res)
{
    Console.WriteLine(res);
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

//Метод подсчёта чётных чисел
int VariantNaive(int[] inputArrey)
{
    //переменная накопления результата
    int result = 0;
    // Буферная переменная
    int i = 0;
    // Пробегаем все элементы массива
    while (i < inputArrey.Length - 1)
    {
        //Сверяем элемент
        if (inputArrey[i] % 2 == 0)
        {
            //Подсчитываем результат
            result++;
        }
        //Увеличиваем инкримент
        i++;
    }
    //Выводим результат
    return result;
}

//метод сортировки пузырьком
void BubbleSort(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = i + 1; j < arr.Length - i - 1; j++)
        {
            if (arr[j] > arr[j + 1])
            {
                int temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
            }
        }
    }
}

//Сортировка методом подсчёта
void CountingSort(int[] arr)
{
    int max = arr.Max();
    int min = arr.Min();
    int[] count = new int[max - min + 1];
    int z = 0;
    for (int i = 0; i < count.Length; i++)
    {
        count[i] = 0;
    }
    for (int i = 0; i < arr.Length; i++)
    {
        count[arr[i] - min]++;
    }
    for (int i = min; i < max; i++)
    {
        while (count[i - min]-- > 0)
        {
            arr[z] = i;
            z++;
        }
    }
}

int[] testArrey = GenArray(123, 100, 999);
CountingSort(testArrey);
Print1DArr(testArrey);
int result = VariantNaive(testArrey);
//Производим явное преобразование int в string через .ToString()
PrintData(result.ToString());
