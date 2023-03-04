// Задайте двумерный массив размером m×n,
// заполненный случайными целыми числами

int ReadData(string msg)
{
      Console.Write(msg);
      return int.Parse(Console.ReadLine() ?? "0");
}
//генерация 2мерного массива 
int[,] Gen2DArray(int countRow, int countColumn, int min, int max)
{
      if (min > max)
      {
            int buf = max;
            max = min;
            min = buf;
      }

      Random rnd = new Random();
      int[,] arr = new int[countRow, countColumn];
      for (int i = 0; i < countRow; i++)
      {
            for (int j = 0; j < countColumn; j++)
            {
                  arr[i, j] = rnd.Next(min, max + 1);
            }
      }
      return arr;
}
// Вывод 2мерного массива + цветная печать
void Print2DArr(int[,] arr)
{
      ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black, ConsoleColor.Blue,
      ConsoleColor.Cyan, ConsoleColor.Gray, ConsoleColor.Yellow, ConsoleColor.Red}; //Добовляем в переменную цвета
      for (int i = 0; i < arr.GetLength(0); i++)
      {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                  Console.ForegroundColor = col[new Random().Next(0,6)]; //Меняем цвет консоли
                  Console.Write(arr[i, j] + " ");
                  Console.ResetColor(); //Сбрасываем цвет консоли
            }
            Console.WriteLine();
      }
}

int row = ReadData("Введите колличество строк: ");
int column = ReadData("Введите колличество столбцов: ");
int[,] arr2D = Gen2DArray(row, column, 10, 99);
Print2DArr(arr2D);
