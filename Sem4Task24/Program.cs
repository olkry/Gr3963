// Напишите программу, которая принимает на вход
// число (А) и выдаёт сумму чисел от 1 до А

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}

