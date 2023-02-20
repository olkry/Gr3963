//Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве.

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string msg, double val)
{
    Console.WriteLine(msg + val);
}

//Метод находит расстояние между точками на плоскости.
double CalcLen3D(int x1, int x2, int y1, int y2, int z1, int z2)
{
    return Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2) + (z1 - z2) * (z1 - z2));
}

int x1 = ReadData("Введите координату Х точки А: ");
int y1 = ReadData("Введите координату Y точки А: ");
int z1 = ReadData("Введите координату Z точки A: ");
int x2 = ReadData("Введите координату X точки B: ");
int y2 = ReadData("Введите координату Y точки B: ");
int z2 = ReadData("Введите координату Z точки B: ");

double result = CalcLen3D(x1, x2, y1, y2, z1, z2);

PrintData("Растояние между точками А и В: ", result);