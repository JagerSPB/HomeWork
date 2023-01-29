// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int GetMaxMinDiff(int[] arr)
{
  int result = 0;
  int max = arr[0];
  int min = arr[0];
  for (int index = 1; index < arr.Length; index++)
  {
    if (arr[index] > max)
    {
      max = arr[index];
    }
    else if (arr[index] < min)
    {
      min = arr[index];
    }
    result = max - min;
  }
  return result;
}

int[] GetArray(int size, int start, int finish)
{
  int[] emptyArray = new int[size];
  for (int index = 0; index < size; index++)
  {
    emptyArray[index] = new Random().Next(start, finish + 1);
  }
  return emptyArray;
}

// генерируем массив
int[] array = GetArray(5, -100, 100);
Console.WriteLine(String.Join(", ", array));

// разница максимального и минимального числа 
int diffMaxMin = GetMaxMinDiff(array);
Console.WriteLine($" разница максимального и минимального числа  -> {diffMaxMin} ");