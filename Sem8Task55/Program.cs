// Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае,
// если это невозможно, программа должна вывести
// сообщение для пользователя.

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
//Метод замены строк со столбцами
void TransArrey(int[,] arr)
{
      int temp = 0;
      for (int i = 0; i < arr.GetLength(1); i++)
      {
            for (int j = i + 1; j < arr.GetLength(0); j++)
            {
                  temp = arr[i, j];
                  arr[i, j] = arr[j, i];
                  arr[j, i] = temp;
            }
      }
}

int nRow = ReadData("Кол-во строк =");
int nColumn = ReadData("Кол-во столбцов =");
int[,] arrey = Gen2DArray(nRow, nColumn, 10, 100);
Print2DArr(arrey);
Console.WriteLine();
if (arrey.GetLength(0) == arrey.GetLength(1))
{
      TransArrey(arrey);
      Print2DArr(arrey);
} 
else Console.WriteLine("Это не квадратная матрица");
