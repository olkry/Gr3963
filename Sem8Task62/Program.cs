// Напишите программу, которая заполнит спирально массив 4 на 4.

//ВНИМАНИЕ!!! это не моя работа!!! обработаная интропретация кода из ChatGPT
//Записал сюда и приложил для личного понимания, прошу не учитывать в зачёте.
//Своими мозгами я не вытянул...

//Ниже приложенно сообщение из ChatGPT целиком, после уже моя адаптация.

// Для заполнения двухмерного массива 4 на 4 спирально можно использовать следующий код:

// ```csharp
// int[,] arr = new int[4, 4];
// int value = 1;
// int row = 0, col = 0;

// while (value <= 16)
// {
//     // Заполнение верхней горизонтальной строки
//     for (int i = col; i < arr.GetLength(1) - col; i++)
//     {
//         arr[row, i] = value++;
//     }

//     // Заполнение правой вертикальной строки
//     for (int i = row + 1; i < arr.GetLength(0) - row; i++)
//     {
//         arr[i, arr.GetLength(1) - col - 1] = value++;
//     }

//     // Заполнение нижней горизонтальной строки в обратном порядке
//     for (int i = arr.GetLength(1) - col - 2; i >= col; i--)
//     {
//         arr[arr.GetLength(0) - row - 1, i] = value++;
//     }

//     // Заполнение левой вертикальной строки в обратном порядке
//     for (int i = arr.GetLength(0) - row - 2; i > row; i--)
//     {
//         arr[i, col] = value++;
//     }

//     // Увеличение индексов начальной строки и столбца для следующей итерации
//     row++;
//     col++;
// }

// // Вывод массива на экран
// for (int i = 0; i < arr.GetLength(0); i++)
// {
//     for (int j = 0; j < arr.GetLength(1); j++)
//     {
//         Console.Write(arr[i, j] + " ");
//     }
//     Console.WriteLine();
// }
// ```

// В данном примере мы используем цикл `while`, который будет выполняться до тех пор, 
// пока не будут заполнены все ячейки массива. Внутри цикла мы заполняем элементы массива по спирали, 
// начиная с верхней левой ячейки и двигаясь по часовой стрелке.
// Для заполнения каждой стороны спирали мы используем отдельный цикл `for`. После заполнения каждой 
// стороны мы увеличиваем индексы начальной строки и столбца для следующей итерации.
// После заполнения массива мы выводим его на экран с помощью двух вложенных циклов `for`.



//Теперь преработка кода. Сделаю универсальный метод для любого размера матрицы.
//Ввод с консоли
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
// Вывод 2мерного массива 
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
}
//Метод спирального заполнения массива. !!!Большая часть кода была подсмотренна в ChatGPT!!!
void SpiralGen2DArrey(int[,] array)
{
    int col = 0;
    int str = 0;
    int val = 1;
    while (val <= array.GetLength(0) * array.GetLength(1))
    {
        for (int i = col; i < array.GetLength(1) - col; i++)
        {
            array[str, i] = val++;
        }
        for (int i = str + 1; i < array.GetLength(0) - str; i++)
        {
            array[i, array.GetLength(1) - col - 1] = val++;
        }
        for (int i = array.GetLength(1) - col - 2; i >= col; i--)
        {
            array[array.GetLength(0) - str - 1, i] = val++;
        }
        for (int i = array.GetLength(0) - str - 2; i > str; i--)
        {
            array[i, col] = val++;
        }
        str++;
        col++;

    }
}

int row = ReadData("Введите число строк: ");
int column = ReadData("Введите число колонн: ");
int[,] matrix = new int[row,column];
SpiralGen2DArrey(matrix);
Print2DArr(matrix);

