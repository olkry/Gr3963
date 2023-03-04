// Задайте двумерный массив размера m на n, каждый
// элемент в массиве находится по формуле: Aₘₙ =
// m+n. Выведите полученный массив на экран

int ReadData(string msg)
{
      Console.Write(msg);
      return int.Parse(Console.ReadLine() ?? "0");
}
//генерация 2мерного массива под задачу
int[,] Gen2DArrayMod(int countRow, int countColumn)
{
      int[,] arr = new int[countRow, countColumn];
      for (int i = 0; i < countRow; i++)
      {
            for (int j = 0; j < countColumn; j++)
            {
                  arr[i, j] = i + j;
            }
      }
      return arr;
}
// Вывод 2мерного массива 
void Print2DArr(int[,] arr)
{

      for (int i = 0; i < arr.GetLength(0); i++)
      {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                  Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
      }
}

int row = ReadData("Введите колличество строк: ");
int column = ReadData("Введите колличество столбцов: ");
int[,] arr2D = Gen2DArrayMod(row, column);
Print2DArr(arr2D);