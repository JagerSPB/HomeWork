// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int GetSumm(int num)
{
  int result;
  for (result = 0; num > 0; result = result + num % 10, num = num / 10) ;
  return result;
}

int inputNum(string text)
{
  Console.WriteLine(text);
  int number = int.Parse(Console.ReadLine());
  return number;
}

// ввод данных пользователя
int num = inputNum("введите число: ");

//находим сумму чисел 
GetSumm(num);

Console.WriteLine("-> " + GetSumm(num));