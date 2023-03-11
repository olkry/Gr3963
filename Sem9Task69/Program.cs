// Напишите программу, которая принимает 2 числа А; Б и возводит А в Б.

//Чтение данных из консоли
int ReadData(string msg)
{
      Console.Write(msg);
      int number = int.Parse(Console.ReadLine() ?? "0");
      return number;
}
// Метод вывода чисел
void PrintResult(long line)
{
      Console.WriteLine(line);
}
// // Метод возведение в степень рекурсивный. Простой
// long RecPow(int a, int b)
// {
//       if (b <= 1)
//       {
//             return a;
//       }
//       else return a * RecPow(a, b - 1);
// }

//Метод преподавателя Андрея.
long AndereysPow(int a, int b)
{
      if (b == 2)
      {
            return 4;
      }
      else
      {
            return AndereysPow(a, b / 2) * AndereysPow(a, b / 2);
      }
}

int numA = ReadData("Введите число A ");
int numB = ReadData("Введите число B ");
PrintResult(AndereysPow(numA, numB));