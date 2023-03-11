// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//Чтение данных из консоли
int ReadData(string msg)
{
    Console.Write(msg);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}
// Метод вывода чисел
void PrintResult(int line)
{
    Console.WriteLine(line);
}
//Рекурсивный метод перемножающий все числа в дипазоне от M до N.
int RecSumDigMN(int m, int n)
{
    if (m >= n)
    {
        return n;
    }
    else
    {
        return m + RecSumDigMN(m + 1, n);
    }
}

int numM = ReadData("Введите число M: ");
int numN = ReadData("Введите число N: ");
int result = numM < numN ? RecSumDigMN(numM, numN) : RecSumDigMN(numN, numM);
PrintResult(result);