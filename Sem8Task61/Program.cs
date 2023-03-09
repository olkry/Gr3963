// Вывести первые N строк треугольника Паскаля.
// Сделать вывод в виде равнобедренного
// треугольника

//Ещё вариант ввода
int ReadData(string msg)
{
    Console.Write(msg);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// n!/k!*(n-k)!

// Метод подсчёта факториала
long Factorieal(int n)
{
    long res = 1;
    for (int i = 1; i <= n; i++)
    {
        res = res * i;
    }
    return res;
}

//     1
//    1 1
//   1 2 1
//  1 3 3 1

//Метод печати триугольника Паскаля
void PrintPascalTriangle(int nRow)
{
    for (int i = 0; i < nRow; i++)
    {
        for (int k = 0; k < nRow-i; k++)
        {
            Console.Write(" ");
        }

        for (int j = 0; j <= i; j++)
        {
            Console.Write(" ");
            Console.Write(Factorieal(i)/(Factorieal(j)*Factorieal(i-j)));
        }
        Console.WriteLine();
    }
}

int countRow = ReadData("Введите количество строк триугольника Паскаля: ");
PrintPascalTriangle(countRow);