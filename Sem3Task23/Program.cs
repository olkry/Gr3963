//Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
//Сразу выполняю с *

int ReadData(string msg)
{
      Console.WriteLine(msg);
      return int.Parse(Console.ReadLine() ?? "0");
}

string LineBuilder(int num, int pow)
{
      string res = String.Empty;
      for (int i = 1; i <= num; i++)
      {
            res = res + Math.Pow(i, pow) + "\t" + "|";
      }
      return res;
}

//Просто разделитель
string OneLine(int num)
{
    string resl = String.Empty;
    for (int l = 1; l <= num; l++)
    {
        resl = resl + "|-------";
    }
    return resl;

}

int number = ReadData("Введите колличество символов:");
//В данном упражнении вводим 3 - 3я степень.
int raz = ReadData("Введите степень:");

Console.WriteLine("|" + LineBuilder(number, 1));
Console.WriteLine(OneLine(number) + "|");
Console.Write("|" + LineBuilder(number, raz));