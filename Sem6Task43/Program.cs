// Напишите программу, которая найдёт точку пересечения двух прямых, заданных
// уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
// пользователем.


int ReadData(string msg)
{
      Console.WriteLine(msg);
      return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string res)
{
      Console.WriteLine(res);
}

double CrossLine(int k1, int b1, int k2, int b2)
{
      double xDot = 0;
      xDot = (b1 - b2) / (k1 - k2);
      return xDot;
}

int numK1=ReadData("Введите число к1");
int numB1=ReadData("Введите число b1");
int numK2=ReadData("Введите число к2");
int numB2=ReadData("Введите число b1");
PrintData($"Точка пересечения по введеным параметрам будет {CrossLine(numK1, numB1, numK2, numB2)}");