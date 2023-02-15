// Напишите программу, которая принимает на вход
// два числа и проверяет, является ли одно число
// квадратом другого. 

int numA = Convert.ToInt32(Console.ReadLine());
int numB = Convert.ToInt32(Console.ReadLine());

//Универсальный метод void
void SqeaTest(int num1, int num2)
{
      if (num1 == num2 * num2)
      {
            Console.WriteLine($"Число {num1} квадрат числа {num2}");

      }
      else
      {
            Console.WriteLine($"Число {num1} не квадрат числа {num2}");
      }
}

SqeaTest(numA, numB);
SqeaTest(numB, numA);
