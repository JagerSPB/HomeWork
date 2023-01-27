// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A 
// в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int GetDegree(int numA, int numB)
{
  int result = 1;
  for (int i = 1; i <= numB; i++)
  {
    result = numA * result;
  }
  return result;
}

int inputNum(string text)
{
  Console.WriteLine(text);
  int number = int.Parse(Console.ReadLine());
  return number;
}

// ввод данных пользователя
int numA = inputNum("введите число А: ");
int numB = inputNum("введите число B: ");

//возводим число А в степень B
int result = GetDegree(numA, numB);

Console.WriteLine($"-> {result} ");