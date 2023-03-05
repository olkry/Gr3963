// Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.

//Считываем данные с консоли
using System;

Console.Write("Введите номер сегодняшнего дня недели ");
string? LineDay = Console.ReadLine();

//Проверяем, чтобы данные были не пустые
if (LineDay != null)
{
      //Парсим введёное число
      int day = int.Parse(LineDay);
      
      //Создаём массив в 7 ячеек
      string[] dayWeek = new string[7];

      //Назначаем ячейки
      dayWeek[0] = "понедельник";
      dayWeek[1] = "вторник";
      dayWeek[2] = "среда";
      dayWeek[3] = "четверг";
      dayWeek[4] = "пятница";
      dayWeek[5] = "суббота";
      dayWeek[6] = "воскресенье";

      Console.WriteLine("Сегодня "+ dayWeek[day - 1]);

      //Вариант с подкачкой баз
      //string outDayOfWeek = System.Globalization.CultureInfo.GetCultureInfo("ru-RU").DateTimeFormat.GetDayName((DayOfWeek)Enum.GetValues(typeof(DayOfWeek)).GetValue(day));
      //Console.WriteLine(outDayOfWeek);

}