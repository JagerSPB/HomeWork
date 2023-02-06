// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов
//  в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

void ShowAvgSumm(int[,] matrix)
{
  Console.Write("Среднее арифметическое каждого столбца: ");
  int rows = matrix.GetLength(0);
  int columns = matrix.GetLength(1);
  for (int j = 0; j < rows; j++)
  {
    float rowAvg = 0;
    for (int i = 0; i < columns; i++)
    {
      rowAvg += matrix[i, j];
    }
    rowAvg /= columns;
    Console.Write($"{rowAvg}; ");
  }
  Console.WriteLine();
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
      Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
  }
}

// Генерируем массив
int[,] matrix = GenerateMatrix(4, 4, 1, 9);

// Выводим массив
ShowMatrix(matrix);
ShowAvgSumm(matrix);