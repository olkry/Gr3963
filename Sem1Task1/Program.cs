// Напишите программу, которая на вход принимает
// два числа и проверяет, является ли первое число
// квадратом второго.

//Считываем данные с консоли
Console.Write("Введите первое число ");
string? numLine1 = Console.ReadLine();
Console.Write("Ведите второе число ");
string? numLine2 = Console.ReadLine();

//Проверяем, чтобы данные были не пустые
if (numLine1 != null && numLine2 != null)
{
      //Парсим введёное число
      int num1 = int.Parse(numLine1);
      int num2 = int.Parse(numLine2);

      //Находим квадрат числа и проверяем равенство
      if (num2 * num2 == num1)
      
            {
                  Console.WriteLine("Первое введёное число являеться корнем второго.");
            }

      else
      {
            Console.WriteLine("Первое введёное число НЕ является корнем второго.");
      }

      
}
