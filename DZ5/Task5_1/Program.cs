// Задача 34: Задайте массив заполненный случайными положительными трёхзначными
// числами. Напишите программу,
//  которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int GetCount(int[] arr)
{
  int count = 0;
  for (int index = 0; index < arr.Length; index++)
  {
    if (arr[index] % 2 == 0)
    {
      count++;
    }
  }
  return count;
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
int[] array = GetArray(10, 100, 1000);
Console.Write("[");
Console.Write(String.Join(", ", array));
Console.WriteLine("]");
// считаем сумму чётных чисел
int countEven = GetCount(array);
Console.WriteLine($"количество чётных чисел -> {countEven}");