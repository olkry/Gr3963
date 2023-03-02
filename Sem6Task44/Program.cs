// Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

int ReadData(string msg)
{
      Console.Write(msg);
      return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string msg)
{
      Console.WriteLine(msg);
}

// Метод поиска числа Фибоначчи
string FibNum(int num)
{
      string res = "0 | 1";
      int first = 0;
      int last = 1;
      for (int i = 2; i < num; i++)
      {
            res = res + " | " + (first + last).ToString();
            (first, last) = (last, first + last); //Это можно записать иначе, как ниже
            // int buf = 0;
            // buf = last;
            // last = last+first;
            // first = buf;

      }
      return res;
}

int numF = ReadData("Введите до какого символа вы хотите открыть число Фибоначчи: ");
PrintData($"Первые {numF} чисел в последовательности Фибоначчи: {FibNum(numF)}");