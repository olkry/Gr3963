// Напишите программу, которая принимает на вход
// число (А) и выдаёт сумму чисел от 1 до А

//Метод ввода чисел
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
// Метод вывода чисел
void PrintResult(string line)
{
    Console.WriteLine(line);
}
// Метод сложения последующих чисел
long SumSimple(int numA)
{
    long sum = 0;
    for (int i = 1; i <= numA; i++)
    {
        sum += i;
        // analog sum=sum+i;
    }
    return sum;
}
// Метод по формуле Гауса ((сумма первого и последнего элемента) *
// умножеть на количество элементов) / делим на 2.
long SumGausse(int numA)
{
    return ((1 + (long)numA) * (long)numA) / 2;
}

int numberA = ReadData("Введите число А:");

//Введём переменную определяющую скорость выполнения программы
DateTime d1 = DateTime.Now;
//Если мы принимаем большие числа, вместо int используй long
long res1 = SumSimple(numberA);
Console.WriteLine(DateTime.Now - d1);

DateTime d2 = DateTime.Now;
long res2 = SumGausse(numberA);
Console.WriteLine(DateTime.Now - d2);

PrintResult("Сумма чисел от 1 до А равна: " + res1);
PrintResult("Сумма чисел от 1 до А равна по Гауссу: " + res2);