//Напишите программу, которая принимает на вход координаты 
// точки x; y (x!=0; y!=0) и выдаёт номер четверти плоскости в которой 
// находится эта точка.

//Спроектируем метод.
// <тип> <имя метода>(<тип> <название переменной>)
// {
//       return <тип>
// }

//Метод для чтения даных пользователя
int ReadData(string msg)
{
      Console.WriteLine(msg);
      return int.Parse(Console.ReadLine() ?? "0");
}

//Метод определяющий четверть по координатам точки
void PrintQuterTest(int x, int y)
{
      if (x > 0 && y > 0) Console.WriteLine("Точка в 1 четверти");
      if (x > 0 && y < 0) Console.WriteLine("Точка в 2 четверти");
      if (x < 0 && y < 0) Console.WriteLine("Точка в 3 четверти");
      if (x < 0 && y > 0) Console.WriteLine("Точка в 4 четверти");
}

//Применяем метод для нахождения x; y.
int coordX = ReadData("Введите координату X: ");
int coordY = ReadData("Введите координату Y: ");

PrintQuterTest(coordX, coordY);