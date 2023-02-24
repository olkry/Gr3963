// // Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в
// натуральную степень B.

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}

long Pow(int a, int b)
{
    long res = 1;
    while (b > 0)
    {
        res = res * a;
        b = b - 1;
    }
    return res;
}

int numA = ReadData("Введите первое число");
int numB = ReadData("Введите второе число");
PrintResult("Результат возведения в степень: " + Pow(numA, numB));
