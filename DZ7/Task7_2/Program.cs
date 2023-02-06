// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет

int[,] GenerateMatrix(int rows, int columns, int lowerBound, int upperBound)
{
  int[,] result = new int[rows, columns];
  for (int i = 0; i < rows; i++)
    for (int j = 0; j < columns; j++)
    {
      result[i, j] = new Random().Next(lowerBound, upperBound + 1);
    }
  return result;
}

void ShowMatrix(int[,] matrix)
{
  int rows = matrix.GetLength(0);
  int columns = matrix.GetLength(1);
  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < columns; j++)
    {
      Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
  }
}

int GetNum(string text)
{
  Console.Write(text);
  int num = int.Parse(Console.ReadLine());
  return num;
}

// Получение размерности от пользователя: m,n
int n = GetNum("(строка)Позиция элемента 1: ");
int m = GetNum("(Колонка)Позиция элемента 2: ");

// Генерируем массив
int[,] matrix = GenerateMatrix(5, 5, 0, 10);

// Выводим результат
ShowMatrix(matrix);

// показываем искомый элемент по индексу в массиве
if (m <= matrix.GetLength(0) && n <= matrix.GetLength(1)) Console.WriteLine($"-> {matrix[n-1, m-1]}");
else Console.WriteLine($"{m}{n} -> такого числа в массиве нет");