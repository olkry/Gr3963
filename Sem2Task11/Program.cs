// Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.

int num = new Random().Next(100, 1000);
Console.WriteLine(num);

// int firstNum = num / 100;
// int therdNum = num % 10;

// num = firstNum * 10 + therdNum;

// Console.WriteLine(num);

Console.WriteLine((num / 100) * 10 + num % 10);