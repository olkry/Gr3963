// Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в
// массиве


int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Генерация массива
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

// Метод с поиском элемента массива и остановкой, как найдёт.
bool SearchElem(int[] arr, int elm)
{
    bool res = false;
    for(int i =0; i<arr.Length; i++)
    {
        if(arr[i] == elm)
        {
            res = true; break;
        }
    }
    return res;
}

// Метод с выведением индекса массива по искомому элементу.
int SearchElemInd(int[] arr, int elm)
{
    int res = -1;
    for(int i =0; i<arr.Length; i++)
    {
        if(arr[i] == elm)
        {
            res = i; break;
        }
    }
    return res;
}

int[] array = Gen1d1DArr(30,-9,9);
Print1DArr(array);
int serch = ReadData("Введите искомое число: ");
Console.WriteLine("Результат поиска числа = " + SearchElem(array, serch));
Console.WriteLine("Индекс искомого числа - " + SearchElemInd(array, serch));