﻿// Задача 34: Задайте массив заполненный случайными положительными трёхзначными
// числами. Напишите программу,
//  которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int GetCount(int[] arr)
{
  int result = 0;
  int count = 1;
  for (int index = 0; index < arr.Length; index++)
  {
    if (arr[index] % 2 == 0)
    {
      result = count++;
    }
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
int[] array = GetArray(10, 100, 1000);
Console.WriteLine(String.Join(", ", array));

// считаем сумму чётных чисел
int countEven = GetCount(array);
Console.WriteLine($"количество чётных чисел -> {countEven}");