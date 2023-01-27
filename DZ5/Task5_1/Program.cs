//Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

void CheckP(int numPd)
{
  int[] numP = new int[5];

  // for (int i = 0; i < 5; i++)
  // {
  //   numP[i] = numPd;
  // }

  if (numP[0] == numP[4] && numP[1] == numP[3])
  {
    Console.WriteLine($"{numPd} - да");
  }
  else
  {
    Console.WriteLine($"{numPd} - нет");
  }
}


int InputNum(string text)
{
  Console.WriteLine(text);
  int num = int.Parse(Console.ReadLine());
  return num;
}

// ввод данных от пользователя
int numPd = InputNum("введите пяти-значное число");
//вывести результат проверки на палидромность
CheckP(numPd);