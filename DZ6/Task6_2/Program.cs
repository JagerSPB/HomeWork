// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
//    x = (b2 - b1) / (k1 - k2);
//    y = (k1 * x + b1);

void FindCrossPoint(double numK1, double numK2, double numB1, double numB2)
{
  if (numK1 == numK2 && numB1 == numB2) Console.WriteLine("Прямые совподают");
  else if (numK1 == numK2) Console.WriteLine("Прямые паралельны");
  else
  {
    double x = (numB2 - numB1) / (numK1 - numK2);
    double y = (numK1 * x + numB1);
    x = Math.Round(x, 2);
    y = Math.Round(y, 2);
    Console.WriteLine($"k1 = {numK1}, k2 = {numK2}, b1 = {numB1}, b2 = {numB2} -> ({x}; {y}) ");
  }
}

double GetValue(string text)
{
  Console.Write(text);
  return double.Parse(Console.ReadLine());
}

double k1 = GetValue("Введите значение k1 ");
double k2 = GetValue("Введите значение k2 ");
double b1 = GetValue("Введите значение b1 ");
double b2 = GetValue("Введите значение b2 ");

FindCrossPoint(k1, k2, b1, b2);