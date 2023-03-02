// Напишите программу, которая будет создавать
// копию заданного одномерного массива с помощью
// поэлементного копирования.

// int ReadData(string msg)
// {
//       Console.Write(msg);
//       return int.Parse(Console.ReadLine() ?? "0");
// }

// void PrintData(string msg)
// {
//       Console.WriteLine(msg);
// }

int[] Gen1DArray(int len, int min, int max)
{
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(min, max + 1);
    }
    return arr;
}


void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

// //Метод копирования массива терез встроенные функции
// int[] CopyArreyStandartTools(int[] inputArr)
// {
//       int[] outArr = new int[inputArr.Length];
//       inputArr.CopyTo(outArr,0); //Цифра - с какого индекса копируем
//       return outArr;
// }

//Универсальный Метод копирования массива терез встроенные функции
object[] UnivCopyArreyStandartTools(params object[] inputArr)
{
      object[] outArr = new object[inputArr.Length];
      inputArr.CopyTo(outArr,0); //Цифра - с какого индекса копируем
      return outArr;
}

int[] testArr = Gen1DArray(40,1,50);
Print1DArr(testArr);
int[] testArrNew = (int[])UnivCopyArreyStandartTools(testArr);
Print1DArr(testArrNew);