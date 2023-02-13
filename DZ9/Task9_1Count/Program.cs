// Задача 64: Задайте значение N. Напишите программу, которая выведет все
//  натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void Rec(int n)
{
  if (n == 0) return;
  {
    Rec(n - 1);
    Console.Write($"{n - 1}, ");
  }
}

int GetNum(string text)
{
  Console.Write(text);
  int num = int.Parse(Console.ReadLine());
  return num;
}

// Получение числа

int num = GetNum("Введите число: ");
Console.Write("-> ");
Rec(num);
Console.WriteLine($"{num}");