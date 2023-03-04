// Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти
// элементы на их квадраты.


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

//Метод приведения массива к условию задачи
void Update2DArr(int[,] arr)
{
      for (int i = 0; i < arr.GetLength(0); i = i + 2)
      {
            for (int j = 0; j < arr.GetLength(1); j = j + 2)
            {
                  //if (i % 2 == 0 && j % 2 == 0)//Проверка, если идём по всем элементам(i++, j++)
                  //{
                        //arr[i, j] = arr[i, j] * arr[i, j]; //Простой способ
                        arr[i, j] *= arr[i, j]; //Способ профессиональней
                        //arr[i, j] = Math.Pow(arr[i, j], 2);
                  //}
            }
      }
}

int row = ReadData("Введите колличество строк: ");
int column = ReadData("Введите колличество столбцов: ");
int[,] arr2D = Gen2DArray(row, column, 0, 9);
Print2DArr(arr2D);
Update2DArr(arr2D);
Print2DArr(arr2D);

