// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

bool PalinTest(int num)
{
    bool res = false;
    if ((num / 10000 == num % 10) && ((num / 1000) % 10 == (num / 10) % 10))
    {
        res = true;
    }
    
    return res;
}



int poll = ReadData("Напишите 5 значное число: ");
bool test = PalinTest(poll);

if (test == true)
{
    Console.WriteLine("Это число палиндром.");
}
else
{
    Console.WriteLine("Это число не полиндром");
}

//СО *

