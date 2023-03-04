// Напишите программу, которая найдёт точку пересечения двух прямых, заданных
// уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
// пользователем. *Найдите площадь треугольника образованного пересечением 3 прямых


double ReadData(string msg)
{
      Console.Write(msg);
      return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string msg)
{
      Console.WriteLine(msg);
}

//Метод нахождения пересечения 2х прямых (y = k1 * x + b1, y = k2 * x + b2)
(double x, double y) CrossPoint(double k1, double b1, double k2, double b2)
{
      double coordX1 = (b2 - b1) / (k1 - k2);
      double coordY1 = (k1 * b1 - k2 * b1) / (k1 - k2);
      return (coordX1, coordY1);
}

//Метод нахождения стороны триугольника, разбит на 3 метода, чтобы получить сразу переменные double
double TriangleSide(double x1, double y1, double x2, double y2)
{
      double res = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));
      return res;
}

//Метод нахождения площади триугольника через полумериметр(p=(a+b+c)/2) сторон и длины сторон
double SquareTriangle(double a, double b, double c)
{
      double squareT = Math.Sqrt(((a + b + c) / 2) * (((a + b + c) / 2) - a) * (((a + b + c) / 2) - b) * (((a + b + c) / 2) - c));
      return squareT;
}

double K1 = ReadData("Введите число K1: ");
double B1 = ReadData("Введите число B1: ");
double K2 = ReadData("Введите число K2: ");
double B2 = ReadData("Введите число B2: ");
double K3 = ReadData("Введите число K3: ");
double B3 = ReadData("Введите число B3: ");

//Поиск координат пересечения
(double x, double y) pointA = CrossPoint(K1, B1, K2, B2);
(double x, double y) pointB = CrossPoint(K2, B2, K3, B3);
(double x, double y) pointC = CrossPoint(K3, B3, K1, B1);

double X1 = pointA.x;
double Y1 = pointA.y;
double X2 = pointB.x;
double Y2 = pointB.y;
double X3 = pointC.x;
double Y3 = pointC.y;
PrintData($"Точки пересечения 3х линий: X1 = {X1}; Y1 = {Y1}; X2 = {X2}; Y2 = {Y2}; X3 = {X3}; Y3 = {Y3}");
double sideA = TriangleSide(X1, Y1, X2, Y2);
double sideB = TriangleSide(X2, Y2, X3, Y3);
double sideC = TriangleSide(X3, Y3, X1, Y1);
PrintData($"Дины сторон триугольника равны A = {sideA}; B = {sideB}; C = {sideC}");
PrintData($"Площадь триугольника: S = {SquareTriangle(sideA, sideB, sideC)}");
