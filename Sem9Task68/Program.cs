// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

//Чтение данных из консоли
int ReadData(string msg)
{
    Console.Write(msg);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}
// Метод вывода чисел
void PrintResult(string line)
{
    Console.WriteLine(line);
}
//Метод функции Аккермана.Двойная рекурсия не вводить числа более 4 в одном из столбцов.
long AkkermanFunction(long m, long n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else
    {
        if (m != 0 && n == 0)
        {
            return AkkermanFunction(m - 1, 1);
        }
        else
        {
            return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
        }

    }
}
//Метод предотвращения Stack overflow.
bool StackОverflow(int m, int n)
{
    bool stack = true;
    if (m == 4 && n >= 0)
    {
        Console.WriteLine("Слишком большая число проходов.");
        stack = false;
    }
    if (m == 3 && n >= 11)
    {
        Console.WriteLine("Слишком большая число проходов.");
        stack = false;
    }
    if (m == 2 && n > 6879)
    {
        Console.WriteLine("Слишком большая число проходов.");
        stack = false;
    }
    if (m == 1 && n >= 13766)
    {
        Console.WriteLine("Слишком большая число проходов.");
        stack = false;
    }
    return stack;
}

int m = ReadData("Введите число M, не более 3, или стек ляжет: ");
int n = ReadData("Введите число N, если в m положил 4, тут только 0: ");
if (StackОverflow(m, n))
{
    PrintResult($"A(m,n) = {AkkermanFunction(m, n)}");
}
else
{
    Console.WriteLine("Тут решения не найти");
}
