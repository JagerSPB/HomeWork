// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] matrix3D = new int[2, 2, 2];

// Функция вывода индекса элементов 3D массива
void ShowMatrix(int[,,] arr)
{
  for (int i = 0; i < matrix3D.GetLength(0); i++)
  {
    for (int j = 0; j < matrix3D.GetLength(1); j++)
    {
      Console.WriteLine();
      for (int k = 0; k < matrix3D.GetLength(2); k++)
      {
        Console.Write($"{matrix3D[i, j, k]}({i},{j},{k}) ");
      }
    }
  }
}

// Функция заполнения 3D массива не повторяющимеся числами
void GenerateMatrix(int[,,] arr)
{
  int count = 11;
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      for (int k = 0; k < arr.GetLength(2); k++)
      {
        arr[k, i, j] += count;
        count += 6;
      }
    }
  }
}
GenerateMatrix(matrix3D);
ShowMatrix(matrix3D);
Console.WriteLine();