// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.

// //Метод генерации 3хмерного массива
// // Тут создан просто для проверке метода.
// void Gen3DArray(int[,,] matr, int min, int max)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             for (int k = 0; k < matr.GetLength(2); k++)
//             {
//                 matr[i, j, k] = new Random().Next(min, max + 1);
//             }

//         }
//     }
// }

//Метод генерации и проверки на неповторение, со списком.
void CheckRep3DArrey(int[,,] arrey, int min, int max)
{
    List<int> usedNum = new List<int>();
    for (int i = 0; i < arrey.GetLength(0); i++)
    {
        for (int j = 0; j < arrey.GetLength(1); j++)
        {
            for (int k = 0; k < arrey.GetLength(2); k++)
            {
                int number = new Random().Next(min, max);
                while (usedNum.Contains(number))
                {
                    number = new Random().Next(min, max);
                }
                arrey[i, j, k] = number;
                usedNum.Add(number);
            }
        }
    }

}
// Вывод 3мерного массива 
void Print3DArr(int[,,] arr)
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.Write(arr[i, j, k] + "\t");
            }
            Console.WriteLine();
        }
    }
}
//Метод для нахождения и печати индекса в массиве.
void IndexPrint3DArrey(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                Console.Write($"{matr[i, j, k]}({i},{j},{k}) \t");
            }
            Console.WriteLine();
        }
    }
}


int[,,] matrix = new int[4, 3, 5];
CheckRep3DArrey(matrix, 1, 99);
Print3DArr(matrix);
Console.WriteLine();
IndexPrint3DArrey(matrix);