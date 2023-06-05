﻿//Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
//возводит число А в целую степень B с помощью рекурсии.
//A = 3; B = 5 -> 243 (3⁵)
//A = 2; B = 3 -> 8

Console.WriteLine ("Введите число:");
int numberA= Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите натуральную степень:");
int numberB= Convert.ToInt32(Console.ReadLine());

int squareRec = SquareRec(numberA,numberB);
Console.WriteLine($"{squareRec}");

int SquareRec(int a, int b)
{
    if (b == 0) return 1;
    return a * SquareRec(a, b-1);
}