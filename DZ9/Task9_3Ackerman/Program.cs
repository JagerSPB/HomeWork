// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// вызов функции Аккермана
void AkkermanFunc(int m, int n)
{
  Console.WriteLine($" -> {Akkerman(m, n)}");
}

// функция Аккермана
int Akkerman(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0 && m > 0) return Akkerman(m - 1, 1);
  else return (Akkerman(m - 1, Akkerman(m, n - 1)));
}

int GetNum(string text)
{
  Console.Write(text);
  int num = int.Parse(Console.ReadLine());
  return num;
}

// Получение чисел для вычесления
int numM = GetNum("Введите число M: ");
int numN = GetNum("Введите число N: ");

AkkermanFunc(numM, numN);