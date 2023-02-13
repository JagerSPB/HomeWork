// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] GenerateMatrix2(int rows, int columns, int lowerBound, int upperBound)
{
  int[,] result = new int[rows, columns];
  for (int i = 0; i < rows; i++)
    for (int j = 0; j < columns; j++)
    {
      result[i, j] = new Random().Next(lowerBound, upperBound);
    }
  return result;
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

int[,] resultArray = new int[m, n];

int[,] MatrixMultiplication(int[,] matrix, int[,] matrix2)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix2.GetLength(1); j++)
    {
      resultArray[i, j] = 0;
      for (int k = 0; k < matrix.GetLength(1); k++)
      {
        resultArray[i, j] += matrix[i, k] * matrix2[k, j];
      }
    }
  }
  return resultArray;
}

// Генерируем 2 массива
int[,] matrix = GenerateMatrix(m, n, 1, 10);
int[,] matrix2 = GenerateMatrix2(m, n, 1, 10);

// Выводим 2 массива
ShowMatrix(matrix);
ShowMatrix(matrix2);

//Перемножаем массивы
MatrixMultiplication(matrix, matrix2);

// Вывод результата
ShowMatrix(resultArray);