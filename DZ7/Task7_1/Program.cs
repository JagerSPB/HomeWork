// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int GetNum(string text)
{
  Console.Write(text);
  int num = int.Parse(Console.ReadLine());
  return num;
}

double[,] GenerateMatrix(int rows, int columns, double lowerBound, double upperBound)
{
  double[,] result = new double[rows, columns];
  Random random = new Random();
  for (int i = 0; i < rows; i++)
    for (int j = 0; j < columns; j++)
    { 
      result[i, j] = random.NextDouble() * (upperBound - lowerBound) + lowerBound;
    }
  return result;
}

void ShowMatrix(double[,] matrix)
{
  int rows = matrix.GetLength(0);
  int columns = matrix.GetLength(1);
  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < columns; j++)
    {
     Console.Write(Math.Round(matrix[i, j],2) + "\t");
    }
    Console.WriteLine();
  }
}

// Получение размерности от пользователя: m,n
int m = GetNum("Введите кол-во строк: ");
int n = GetNum("Введите кол-во столбцов: ");

// Генерируем массив
double[,] matrix = GenerateMatrix(m, n, -10, 10);

// Выводим результат
ShowMatrix(matrix);