// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом
// столбце.

int ReadData(string msg)
{
      Console.Write(msg);
      return int.Parse(Console.ReadLine() ?? "0");
}
//генерация 2мерного массива под задачу
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

void Print1DArr(double[] arr)
{
      Console.Write("[");
      for (int i = 0; i < arr.Length - 1; i++)
      {
            Console.Write(arr[i] + ", ");
      }
      Console.Write(arr[arr.Length - 1]);
      Console.WriteLine("]");
}
//Метод подсчёта среднеарефметич в колоннах
double[] ColMean2DArr(int[,] arr);
{
      double[] resArr = new double[arr.GetLength(1)];
      for (int j = 0; j < arr.GetLength(1); j++)
      {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                  resArr[j] += arr[i, j];
            }
            resArr[j] = resArr[j] / arr.GetLength(0);
      }

      return resArr;
}

