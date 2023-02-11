// Напишите программу, которая на вход принимает
// одно число (N), а на выходе показывает все целые
// числа в промежутке от -N до N.

Console.Write("Задайте число ");
string? LineN = Console.ReadLine();

if (LineN != null)
{
      int N = int.Parse(LineN);
      string res = String.Empty;
      int negN = N * -1;

      while (negN <= N)
      {
            res = res + negN + " ";
            negN = negN + 1;
      }
      Console.WriteLine(res);

}