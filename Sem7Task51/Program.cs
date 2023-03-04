// Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной 
// диагонали (синдексами (0,0); (1;1) и т.д.

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
void PrintData(int msg)
{
      Console.WriteLine(msg);
}

//Метод просчитывания диагонали
int CallMainDiag(int[,] arr)
{
      int res = 0;
      //сщздадим переменную для определение минимального значения длины
      int min = arr.GetLength(0) > arr.GetLength(1) ? arr.GetLength(1) : arr.GetLength(0);//ниже приведу аналог
      // int min = arr.GetLength(0);
      // if(arr.GetLength(0)>arr.GetLength(1))
      // {
      //       min = arr.GetLength(1);
      // }
      for (int i = 0; i < min; i++)
      {
            res = res + arr[i, i];
      }
      return res;
}

int row = ReadData("Введите колличество строк: ");
int column = ReadData("Введите колличество столбцов: ");
int[,] arr2D = Gen2DArray(row, column, 0, 9);
Print2DArr(arr2D);
int nwarr = CallMainDiag(arr2D);
PrintData(nwarr);