// Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и
// столбец, на пересечении которых расположен
// наименьший элемент массива.

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

int[,] Update2DArrey(int[,] arr, int row, int column)
{
      int[,] res = new int[arr.GetLength(0) - 1, arr.GetLength(1) - 1];
      int k = 0;
      int m = 0;
      for (int i = 0; i < arr.GetLength(0); i++)
      {
            m = 0;
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                  if (j != column && i != row)
                  {
                        res[k, m] = arr[i, j];

                  }
                  if (j != column) m++;
            }
            if (i != row) k++;

      }

      return res;
}

//Метод нахождения минимального элемента матрицы
(int x, int y) MinElem2DArr(int[,] matr)
{
      int row = 0;
      int column = 0;
      int min = int.MaxValue;
      for (int i = 0; i < matr.GetLength(0); i++)
      {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                  if (matr[i, j] < min)
                  {
                        min = matr[i, j];
                        row = i;
                        column = j;
                  }
            }

      }
      return (row, column);
}

Console.Clear();
int nRow = ReadData("Кол-во строк =");
int nColumn = ReadData("Кол-во столбцов =");
int[,] arrey = Gen2DArray(nRow, nColumn, 0, 99);
Print2DArr(arrey);
Console.WriteLine();
(int x, int y) minElem = MinElem2DArr(arrey);
int[,] finalArr = Update2DArrey(arrey, minElem.x, minElem.y);
Print2DArr(finalArr);