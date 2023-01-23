//Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

void CheckP(int numP)
{
  if ((numP % 10) == (numP / 10000) && ((numP / 1000) % 10) == ((numP % 100) / 10))
  {
    Console.WriteLine("-> да");
  }
  else
  {
    Console.WriteLine("-> нет");
  }
}

int InputNum(string text)
{
  Console.WriteLine(text);
  int num = int.Parse(Console.ReadLine());
  return num;
}
// ввод данных от пользователя
int numP = InputNum("введите пяти-значное число");

//вывести результат проверки на палидромность
CheckP(numP);