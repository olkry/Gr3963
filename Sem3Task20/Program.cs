//Напишите программу, которая принимает на вход координаты 2х точек
// и находит расстояние между этими двумя точками в 2Д пространстве.

//Метод читает данные пользователя
int ReadData(string msg)
{
      Console.WriteLine(msg);
      return int.Parse(Console.ReadLine() ?? "0");
}

//Метод выводит данные пользователя
void PrintData(string msg, double val)
{
      Console.WriteLine(msg + val);
}

//Метод находит расстояние между точками на плоскости.
// double - будет дробное число.
double CalcLen2D(int x1, int x2, int y1, int y2)
{
      //Math - класс - математические функции. Sqrt - корень квадратный.
      return Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
}

int x1 = ReadData("Введите координату Х точки А: ");
int y1 = ReadData("Введите координату Y точки А: ");
int x2 = ReadData("Введите координату Х точки B: ");
int y2 = ReadData("Введите координату Y точки B: ");

double res = CalcLen2D(x1, x2, y1, y2);

PrintData("Растояние между точками А и В: ", res);