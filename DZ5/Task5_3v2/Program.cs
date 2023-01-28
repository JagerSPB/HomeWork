// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double GetMaxMinDiff(double[] arr)
{
  double result = 0;
  double min = arr[0];
  double max = arr[0];
  for (int index = 0; index < arr.Length; index++)
  {
    if (arr[index] > max)
    {
      max = arr[index];
    }
    if (arr[index] < min)
    {
      min = arr[index];
    }
    result = max - min;
  }
  return result;
}

double[] GetArray(int size, int start, int finish)
{
  double[] emptyArray = new double[size];
  for (int index = 0; index < size; index++)
  {
   emptyArray[index] = Convert.ToDouble(new Random().Next(start, finish)) / 100;
  }
  return emptyArray;
}

// генерируем массив
double[] array = GetArray(6, 100, 10000);
Console.WriteLine(String.Join(", ", array));

// разница максимального и минимального числа 
double diffMaxMin = GetMaxMinDiff(array);
Console.WriteLine($" разница максимального и минимального числа  -> {Math.Round(diffMaxMin, 2)} ");