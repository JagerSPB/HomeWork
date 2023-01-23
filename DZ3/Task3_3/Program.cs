// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

void GetN(int numN)
{
  int i = 1;
  while (i < numN)
  {
    Console.Write(Math.Pow(i, 3) + ", ");
    i++;
  }
  Console.WriteLine(Math.Pow(numN, 3));
}

int GetNum(string text)
{
  Console.Write(text);
  int num = int.Parse(Console.ReadLine());
  return num;
}

// ввод данных от пользователя
int numN = GetNum("введите значение: ");
Console.Write("-> ");

//вывести таблицу квадратов
GetN(numN);