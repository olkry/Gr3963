//Напишите программу, которая принимает на вход
//число N и выдаёт произведение чисел от 1 до N.

//Подглючаем дополнительные функции
using System.Numerics;

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}

BigInteger FactorCalc(int num)
{
    BigInteger res = 1;
    for (int i = 2; i <= num; i++)
    {
        res = res * i;
    }
    return res;
}
int factor = ReadData("Введите число");
PrintResult("Интегралл равен: " + FactorCalc(factor));
