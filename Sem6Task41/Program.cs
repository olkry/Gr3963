// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл
// пользователь.

// int ReadData(string msg)
// {
//     Console.WriteLine(msg);
//     return int.Parse(Console.ReadLine() ?? "0");
// }

// void PrintData(string res)
// {
//     Console.WriteLine(res);
// }

// int CountNum(int numM)
// {
//       int res = 0;
//       for (int i =0; i<numM; i++)
//       {
//             if(ReadData("добавь")>0)
//             {
//                   res++;
//             }
//       }
//       return res;
// }

// int num = ReadData("введите число: ");
// PrintData($"Пользователь ввёл {CountNum(num)} положительных чисел");

// вариант со *Пользователь вводит число нажатий, затем программа следит за нажатиями и выдает сколько чисел больше 0 было введено.

// Сборка для регулярных выражений
using System.Text.RegularExpressions;

int taps = ReadData("Введите колличество нажатий");
string inputLine = ReadLineData("Введите любые символы");
FindNumberInString(inputLine, taps);

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Метод считывает нажатие клавиш заданное кол-во раз и собирает данные в строку
string ReadLineData(string msg)
{
    Console.WriteLine(msg);
    string line = "";
    for (int i = 0; i < taps; i++)
    {
        var key = Console.ReadKey(true); //Параметр true для того, чтобы после нажатия клавиш ничего не появилось в консоли.
        line = line + String.Format(key.KeyChar.ToString()) + ",";
    }
    line = line.TrimEnd(','); //осекаем последнюю запятую
    return line;
}

//Метод для поиска десятичных цифр в строке с помощью регулярных выражений
void FindNumberInString(string str, int count)
{
    Regex regex = new Regex(@"\d"); //задаём для поиска параметр "любая десетичная цифра"
    MatchCollection matches = regex.Matches(str); //задаём коллекцию сщстоящую из найденных по условию выражений
    int posNums = 0;
    if (matches.Count > 0) //если цифры найдены, накапливаем результат
    {
        foreach (Match match in matches)
        {
            posNums = posNums + 1;
        }
        Console.WriteLine($"Совершено нажатий: {count}. Чисел найдено: {posNums}");
    }
    else
    {
        Console.WriteLine($"Совершено нажатий: {count}. Чисел не найдено.");
    }
}

