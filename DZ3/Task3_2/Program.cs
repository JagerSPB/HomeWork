// Напишите программу, которая принимает на вход координаты двух точек и находит
// расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2


void GetDist(double x1, double y1, double x2, double y2, double z1, double z2)

{
  double dist = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
  Console.WriteLine(Math.Round(dist, 2));
}

double GetNum(string text)
{
  Console.WriteLine(text);
  double num = double.Parse(Console.ReadLine());
  return num;
}
// ввод данных от пользователя x, y, z
double x1 = GetNum("введите значение X1");
double y1 = GetNum("введите значение Y1");
double z1 = GetNum("введите значение Z1");
double x2 = GetNum("введите значение X2");
double y2 = GetNum("введите значение Y2");
double z2 = GetNum("введите значение Z2");

Console.Write("Distance is: ");

// определить расстояние 
GetDist(x1, y1, x2, y2, z1, z2);