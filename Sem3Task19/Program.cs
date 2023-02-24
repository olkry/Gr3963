// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

// int ReadData(string msg)
// {
//     Console.WriteLine(msg);
//     return int.Parse(Console.ReadLine() ?? "0");
// }

// bool PalinTest(int num)
// {
//     bool res = false;
//     if ((num / 10000 == num % 10) && ((num / 1000) % 10 == (num / 10) % 10))
//     {
//         res = true;
//     }

//     return res;
// }



// int poll = ReadData("Напишите 5 значное число: ");
// bool test = PalinTest(poll);

// if (test == true)
// {
//     Console.WriteLine("Это число палиндром.");
// }
// else
// {
//     Console.WriteLine("Это число не полиндром");
// }

//СО звездой.

// method read input data from console
int ReadData(string msg)
{
      Console.WriteLine(msg);
      return int.Parse(Console.ReadLine() ?? "0");
}
// method print result to console
void PrintData(int num, string msg)
{
      Console.WriteLine(num + msg);
}

// method fill a dictionary with four-digit palindrome
Dictionary<int, int> DictionaryFill()
{
      Dictionary<int, int> dictionary = new Dictionary<int, int>();
      int keyNumber = 1;
      for (int seoundNumber = 0; seoundNumber <= 9; seoundNumber++)
      {
            for (int firstNumber = 1; firstNumber <= 9; firstNumber++)
            {
                  dictionary[keyNumber] = firstNumber * 1000 + seoundNumber * 100 + seoundNumber * 10 + firstNumber;
                  keyNumber++;
            }
      }
      return dictionary;
}

// Method test if the five-diget number is a palindrome
bool PalinTest(int number, Dictionary<int, int> palindrome)
{
      bool result = false;
      //12321->1221
      if (palindrome.ContainsValue((number / 1000) * 100 + (number % 100)))
      {
            result = true;
      }
      return result;
}

//read output data
int outputNumber = ReadData("Inter a five-digit number ");
// cheking the correctness of the entered data
if (outputNumber >= 10000 && outputNumber <= 99999)
{
      // creat a dictionary with with four-digit palindromes
      Dictionary<int, int> palindrome = DictionaryFill();
      // check if there is an input number in dictionary
      bool check = PalinTest(outputNumber, palindrome);
      if (check)
      {
        PrintData(outputNumber, " is a palindrome");
      }
      else
      {
        PrintData(outputNumber, " is not a palindrome");
      }
}
else
{
    Console.WriteLine("Inpute number isn't correct. It shoul be from 10000 to 99999");
}


