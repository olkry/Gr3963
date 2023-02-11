// Напишите программу, которая принимает на вход
//  число и на выходе показывает последнюю цифру этого числа

Console.Write("Введите число");
string? lineN = Console.ReadLine();

if(lineN != null)
{
      int N = int.Parse(lineN);
      int res = N % 10;

      Console.WriteLine(res);

}