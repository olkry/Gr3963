// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл
// пользователь.

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string res)
{
    Console.WriteLine(res);
}

int CountNum(int numM)
{
      int res = 0;
      for (int i =0; i<numM; i++)
      {
            if(ReadData("добавь")>0)
            {
                  res++;
            }
      }
      return res;
}

int num = ReadData("введите число: ");
PrintData($"Пользователь ввёл {CountNum(num)} положительных чисел");

