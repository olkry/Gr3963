// Напишите программу, которая выводит случайное
// число из отрезка [10, 99] и показывает наибольшую
// цифру числа. 

// Создаём новый рандом
System.Random numSintezator = new System.Random();

// Вариант 1
//Задаём приделы рандома и сразу выводим результат
int rndNumber = numSintezator.Next(10, 100);
Console.WriteLine(rndNumber);

//Дробим число, чтобы определить составные числа
int firstNum = rndNumber / 10;
int secondNum = rndNumber % 10;

// Теперь запишим наибольшее
if (firstNum > secondNum)
{
      Console.WriteLine("Большее число " + firstNum);
}
else
{
      Console.WriteLine("Большее число " + secondNum);
}

//Вариант 2
//Берём тип - символы в массив. Далее задаём приделы рандома. 
//После чего переводим число в строку, затем её в массив символов.
//Сразу его выведем
char[] digits = numSintezator.Next(10, 100).ToString().ToCharArray();
Console.WriteLine(digits);
// Система берёт числа из таблицы ASCII, она кодирует с прибавлением в 48.
// работает только с цыфрами.
int firstNumber = ((int)digits[0]) - 48;
int secondNumber = ((int)digits[1]) - 48;

//Тернарный оператор
//<переменная> = (условие)?<значене1>:<значение2>;
// if(условие)
// {
//       <переменная> = <значене1>;
// }
// else
// {
//       <переменная> = <значене2>;
// }
int resultNumber = (firstNumber > secondNumber) ? resultNumber = firstNumber : resultNumber = secondNumber;
Console.WriteLine(resultNumber);

//вариант 3

