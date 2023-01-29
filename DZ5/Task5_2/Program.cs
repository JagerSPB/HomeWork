// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
//стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int GetSum(int[] arr)
{
  int result = 0;
  for (int index = 1; index < arr.Length; index += 2)
  {
    result = result + arr[index];
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
int[] array = GetArray(6, -100, 100);
Console.WriteLine(String.Join(", ", array));

// считаем сумму на не чётных позициях массива
int summ = GetSum(array);
Console.WriteLine($"сумма чисел, не чётных позиций массива -> {summ}");