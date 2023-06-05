// Задача 67: Напишите программу, которая будет принимать на вход число и
//возвращать сумму его цифр.
//453 -> 12
//45 -> 9

Console.WriteLine("введите натуральное число");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(FactorialSum(n));

int FactorialSum(int n)
 {
     if (n == 0) return 0;
     else return n % 10 + FactorialSum(n/10);
 }