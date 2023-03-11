// Задайте значения M и N. Напишите программу, которая найдёт все натуральные элементы в промежутке от M до N

//Чтение данных из консоли
int ReadData(string msg)
{
      Console.Write(msg);
      int number = int.Parse(Console.ReadLine() ?? "0");
      return number;
}
// Метод вывода чисел
void PrintResult(string line)
{
      Console.WriteLine(line);
}
//Метод набирающий результат
string RecMN(int m, int n)
{
      string res = string.Empty;
      if (m >= n)
      {
            res = n.ToString();
      }
      else
      {
            res = res + m + " " + RecMN(m + 1, n);
      }
      return res;
}

int numM = ReadData("Задайте число M: ");
int numN = ReadData("Задайте число N: ");
//Защита от дурака
string resultLine = numM < numN ? RecMN(numM, numN) : RecMN(numN, numM);
PrintResult(resultLine);


