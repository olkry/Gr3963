// Напишите программу, которая принимает на вход
// три числа и проверяет, может ли существовать
// треугольник с сторонами такой длины.

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string res, bool value)
{
    Console.WriteLine(res + value);
}

// Тест на возможность составить триугольник
bool TriengleTest(int a, int b, int c)
{
    bool res = false;
    //if ((a <= b + c) && (b <= a + c) && (c <= b + a)) // Способ без использования метода теста сторон.
    if (Test(a, b, c) && Test(b, a, c) && Test(c, a, b)) //Используем метод проверки сторон, получается рекурсия
    {
        res = true;
    }
    return res;
}

// Метод теста сторон
bool Test(int a, int b, int c)
{
    if (a <= b + c) return true;
    else return false;
}

int a = ReadData("Введите сторону а");
int b = ReadData("Введите сторону b");
int c = ReadData("Введите сторону c");
Test(a, b, c);
PrintData("Такой триугольник ", TriengleTest(a, b, c));