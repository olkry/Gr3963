// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// *Заполнить числами Фиббоначи и выделить цветом найденную цифру

//Метод ввода данных
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
    
}
//Метод заполнения числами Фибоначчи.
int[,] FibonacciArrey(int countRow, int countColumn)
{
    int[,] fibArr = new int[countRow, countColumn];
    int aNum = 0;
    int bNum = 1;
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            if (i == 0 && j == 0) fibArr[i, j] = 0;
            else if (i == 0 && j == 1) fibArr[i, j] = 1;
            else
            {
                fibArr[i, j] = aNum + bNum;
                int temp = aNum;
                aNum = bNum;
                bNum = aNum + temp;
            }
        }
    }
    return fibArr;
}
//Метод вывода массива
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
    Console.WriteLine();
}
//Метод поиска нужного числа
void SerchNum(int[,] arr, int serNum)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] == serNum)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(arr[i, j] + "\t");
                Console.ResetColor();
            }
            else Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
//Метод вывода сообщения о запрошенном числе
bool CommentNum(int[,] arr, int elem)
{
    bool result = false;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] == elem) 
            {
                result = true; 
                break;
            } 
        }
    }
    Console.WriteLine();
    if (result == true) Console.Write($"Число {elem} найдено и помечено");
    else Console.Write($"Число {elem} в массиве не обнаруженно");
    return result;
}


//   Console.Write($"Число {elem} в массиве не обнаруженно");
//     Console.Write($"Число {elem} найдено и помечено");

int row = ReadData("Введите колличество строк: ");
int column = ReadData("Введите колличество столбцов: ");
int[,] fibonacci = FibonacciArrey(row, column);
Print2DArr(fibonacci);
int serchNum = ReadData("Какое число желаете найти? ");
SerchNum(fibonacci, serchNum);
CommentNum(fibonacci, serchNum);