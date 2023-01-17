// Задача 10: Напишите программу, которая принимает на вход трёхзначное 
// число и на выходе показывает вторую цифру этого числа.
//  456 -> 5
//  782 -> 8
//  918 -> 1

Console.WriteLine("Введите число ");
int num = int.Parse(Console.ReadLine());

int numA = num / 100;
int numC = num % 10;
int numB = num - (((numA*100) + numC));
int result = numB / 10;
Console.WriteLine($"-> {result} ");