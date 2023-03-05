// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// * При выводе матрицы показывать каждую цифру разного цвета(цветов всего 16). Ограничить дробь 2мя числами.

int ReadData(string msg)
{
      Console.Write(msg);
      return int.Parse(Console.ReadLine() ?? "0");
}
//генерация 2мерного массива вещественных чисел
double[,] Gen2DArray(int countRow, int countColumn, int min, int max)
{
      if (min > max)
      {
            int buf = max;
            max = min;
            min = buf;
      }

      double[,] arr = new double[countRow, countColumn];
      for (int i = 0; i < countRow; i++)
      {
            for (int j = 0; j < countColumn; j++)
            {
                              //Тут генерируется целая часть    //Тут генерируется дробная часть.
                  arr[i, j] = new Random().Next(min, max + 1) + new Random().NextDouble();
                  arr[i, j] = Math.Round(arr[i, j], 2);
            }
      }
      return arr;
}
// Вывод 2мерного массива + цветная печать
void Print2DArr(double[,] arr)
{
      ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black, ConsoleColor.DarkBlue, ConsoleColor.DarkGreen,
      ConsoleColor.DarkCyan, ConsoleColor.DarkRed, ConsoleColor.DarkMagenta, ConsoleColor.DarkYellow, ConsoleColor.Gray, 
      ConsoleColor.DarkGray, ConsoleColor.Blue, ConsoleColor.Green, ConsoleColor.Cyan, ConsoleColor.Red,
      ConsoleColor.Magenta, ConsoleColor.Yellow, ConsoleColor.White}; //Добовляем в переменную цвета
      for (int i = 0; i < arr.GetLength(0); i++)
      {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                  Console.ForegroundColor = col[new Random().Next(0,16)]; //Меняем цвет консоли
                  Console.Write(arr[i, j] + "\t");
                  Console.ResetColor(); //Сбрасываем цвет консоли
            }
            Console.WriteLine();
      }
}

int row = ReadData("Введите колличество строк: ");
int column = ReadData("Введите колличество столбцов: ");
double[,] arr2D = Gen2DArray(row, column, 10, 99);
Print2DArr(arr2D);