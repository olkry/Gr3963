// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в
// числе.

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}

int DigitSum(int num)
{
    int res = 0;
    while (num > 0)
    {
        res = res + num % 10;
        num = num / 10;
    }
    return res;
}

int number = ReadData("Введите число:");
PrintResult("Сумма всех цифр числа: " + DigitSum(number));