// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите первое число: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int numC = Convert.ToInt32(Console.ReadLine());

if (numA > numB)
{
    if (numA > numC)
    {
        Console.WriteLine("Большее число - " + numA);
    }
    else
    {
        Console.WriteLine("Большее число - " + numC);
    }
}
else
{
    if(numB>numC)
    {
        Console.WriteLine("Большее число - " + numB);
    }
    else
    {
        Console.WriteLine("Большее число - " + numC);
    }
}
