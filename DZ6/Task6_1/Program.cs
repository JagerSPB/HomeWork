// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

//===============================

int NumberM(string text)
{
  Console.WriteLine(text);
  int numM = int.Parse(Console.ReadLine());
  int count = 0;
  for (int i = 0; i < numM; i++)
  {
    Console.Write($"Введите число {i + 1}: ");
    int x = int.Parse(Console.ReadLine());
    if (x > 0)
      count++;
  }
  return count;
}

// ввод данных пользователя
int number = NumberM("Введите колличество чисел: ");

Console.WriteLine($"-> {number}");