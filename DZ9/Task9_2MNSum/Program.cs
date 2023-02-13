// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

void RecSum(int m, int n)
{
  Console.WriteLine($" -> {SumMN(m - 1, n)}");
}

int SumMN(int m, int n)
{
  int result = m;
  if (m >= n) return 0;
  else
  {
    m++;
    result = m + SumMN(m, n);
    return result;
  }
}

int GetNum(string text)
{
  Console.Write(text);
  int num = int.Parse(Console.ReadLine());
  return num;
}

// Получение 
int numM = GetNum("Введите число M: ");
int numN = GetNum("Введите число N: ");

RecSum(numM, numN);