//Напишите программу, которая принимает на вход
// число и выдаёт количество цифр в числе.
//Начальный вариант

Console.Write("Введите трёх или более значное число: ");
string num = Console.ReadLine();
// Превращаем его в массив
DateTime d1 = DateTime.Now;
char[] arr = num.ToCharArray();
//Выводим третью цифру числа.
int str = arr.Length;
Console.WriteLine("Количество символов в числе: " + str);
Console.WriteLine(DateTime.Now - d1);

//С доски
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
        res += 1;
        num = num / 10;
    }
    return res;
}

int numA = ReadData("Введите число ");
DateTime d2 = DateTime.Now;
PrintResult("Количество символов в числе: " + DigitSum(numA));
Console.WriteLine(DateTime.Now - d2);



