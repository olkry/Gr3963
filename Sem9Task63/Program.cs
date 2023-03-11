// Задайте значение N. Напишите программу, которая выдаёт все натуральные
// числав промежутке от N до 1. Выполнить с помощью рекурсии.

//Чтение данных из консоли
int ReadData(string msg)
{
      Console.Write(msg);
      int number = int.Parse(Console.ReadLine() ?? "0");
      return number;
}
//Метод набирающий результат
void LineGenRec(int num)
{
      Console.Write(num + " ");
      if (num == 1)
      {
      }
      else
      {
            LineGenRec(num - 1);
      }

}

int number = ReadData("Введите число N: ");
LineGenRec(number);
