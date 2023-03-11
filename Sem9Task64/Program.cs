// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N. Выполнить с помощью рекурсии.

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
//Метод набирающий результат с магическим числом.
string RecMNStart(int m, int start)
{

    string res = string.Empty;
    if (start >= m)
    {
        res = start.ToString();
    }
    else
    {
        res = res + start + " " + RecMNStart(m, start + 1);
    }
    return res;
}

//Далее нерабочий метод, 
//Метод набирающий результат
// string RecMN(int m)
// {

//     string res = string.Empty;
//     if (1 >= m)
//     {
//         res = m.ToString();
//     }
//     else
//     {
//         res = res + m + " " + RecMN(m - 1);
//     }
//     return(res);

// }
// //Метод реверсии
// string ReversResult(string result)
// {
//     char[] resRev = result.ToCharArray();
//     Array.Reverse(resRev);
//     result = new string(resRev);
//     return result;
// }


int numM = ReadData("Введите крайнее число: ");
//Вариант с волшебным числом
int startL = 1;
PrintResult(RecMNStart(numM, startL));

//Вариант с реверсом. Пока не разобрался
// string rev = ReversResult(RecMN(numM));

// PrintResult(rev);



