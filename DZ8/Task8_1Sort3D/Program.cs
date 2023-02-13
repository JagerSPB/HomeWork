// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

void SortArray(int[,] array)
{
  int rows = array.GetLength(0);
  int cols = array.GetLength(1);

  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < cols - 1; j++)
    {
      int max = array[i, j];
      int maxInd = j;
      for (int k = j + 1; k < cols; k++)
        if (array[i, k] > max)
        {
          max = array[i, k];
          maxInd = k;
        }
      (array[i, j], array[i, maxInd]) = (array[i, maxInd], array[i, j]);
    }
  }
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

int GetNum(string text)
{
  Console.Write(text);
  int num = int.Parse(Console.ReadLine());
  return num;
}

// Получение размерности от пользователя: m,n
int m = GetNum("Введите кол-во строк: ");
int n = GetNum("Введите кол-во столбцов: ");

// Генерируем массив
int[,] matrix = GenerateMatrix(m, n, 1, 9);

// Выводим массив
ShowMatrix(matrix);

// сортируем массив 
SortArray(matrix);

ShowMatrix(matrix);