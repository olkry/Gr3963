// Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается
// элемент входных данных.

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
//Метод заполнения частотного словаря
int[] FreqDicBuild(int[,] arr, int len)
{
      int[] dik = new int[len];

      for (int i = 0; i < arr.GetLength(0); i++)
      {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                  dik[arr[i,j]]++;
            }
      }

      return dik;
}

Console.Clear();
int nRow = ReadData("Кол-во строк =");
int nColumn = ReadData("Кол-во столбцов =");
int[,] arrey = Gen2DArray(nRow, nColumn, 0, 1);
Print2DArr(arrey);
Console.WriteLine();
Print1DArr(FreqDicBuild(arrey, 2));
