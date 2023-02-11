// Напишите программу, которая на вход принимает
// число и выдаёт его квадрат (число умноженное на
// само себя).

Console.WriteLine("Введите число");
//Считываем данные с консоли
string? inputNum = Console.ReadLine();

//Проверяем, чтобы данные были не пустые
if (inputNum != null)
{
      //Парсим введёное число
      int number = int.Parse(inputNum);

      //Находим квадрат числа
      //int outNum = number * number;
      int outNum = (int)Math.Pow(number, 2);

      //Выводим данные в консоль
      Console.WriteLine("Квадрат числа: " + outNum);

      // Всё вышеописанное от иф 1 строкой
      // Console.WriteLine("Квадрат числа: " + Math.Pow(int.Parse(inputNum), 2));
}