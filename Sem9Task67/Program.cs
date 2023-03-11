// 

//Чтение данных из консоли
int ReadData(string msg)
{
      Console.Write(msg);
      int number = int.Parse(Console.ReadLine() ?? "0");
      return number;
}
// Метод вывода чисел
void PrintResult(int line)
{
      Console.WriteLine(line);
}

int RecSumDig(int num)
{
      if (num == 0)
      {
            return 0;
      }
      else
      {
            return num % 10 + RecSumDig(num / 10);
      }
}

int number = ReadData("Введите число");
PrintResult(RecSumDig(number));



