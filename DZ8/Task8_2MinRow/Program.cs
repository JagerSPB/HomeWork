// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет
// находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей 
// суммой элементов: 1 строка

int[,] GenerateMatrix(int rows, int columns, int lowerBound, int upperBound)
{
  int[,] result = new int[rows, columns];
  for (int i = 0; i < rows; i++)
    for (int j = 0; j < columns; j++)
    {
      result[i, j] = new Random().Next(lowerBound, upperBound);
    }
  return result;
}

void NumberMinRow(int[,] matrix)
{
  int minRow = 0;
  int minSumRow = 0;
  int calculateRow = 0;
  for (int i = 0; i < matrix.GetLength(1); i++)
  {
    minRow += matrix[0, i];
  }
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++) calculateRow += matrix[i, j];
    if (calculateRow < minRow)
    {
      minRow = calculateRow;
      minSumRow = i;
    }
    calculateRow = 0;
  }
  Console.WriteLine($"{minSumRow + 1} строка");
}

void ShowMatrix(int[,] matrix)
{
  Console.WriteLine();
  int rows = matrix.GetLength(0);
  int columns = matrix.GetLength(1);
  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < columns; j++)
    {
      Console.Write(String.Format("{0,3} ", matrix[i, j]));
    }
    Console.WriteLine();
  }
}

// Генерируем массив
int[,] matrix = GenerateMatrix(4, 4, 1, 9);

// Выводим массив
ShowMatrix(matrix);

// Вызываем результат подсчета строк
NumberMinRow(matrix);