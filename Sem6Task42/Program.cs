// Напишите программу, которая будет
// преобразовывать десятичное число в двоичное.

int ReadData(string msg)
{
      Console.Write(msg);
      return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string msg)
{
      Console.WriteLine(msg);
}

//Метод перевода числа в двоичную систему
// string DecToBin(int num)
// {
//       string res = string.Empty;
//       while (num > 0)
//       {
//             res = num % 2 + res;
//             num = num / 2;
//       }
//       return res;
// }

//Метод конвертации числа
string DecToBinNativ(int num, int base1)
{
      return Convert.ToString(num, base1); //Тут после числа, через запятую стоит в какую систему.
}

int number = ReadData("Введите число для преобразования в двоичную систему: ");
PrintData("В двоичной системе " + DecToBinNativ(number, 2));
PrintData($"В двоичной системе число {number} = {DecToBinNativ(number, 8)}");
PrintData("В двоичной системе число " + number + " = " + DecToBinNativ(number, 16));