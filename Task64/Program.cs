//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.


Console.Write("Введите натуральное число N: ");
double numberN = Convert.ToDouble(Console.ReadLine());

if (numberN < 0 || numberN % 1 != 0)
{

    Console.Write("Это не натуральное число");
    return;
}

NaturaleNumbers(numberN);

void NaturaleNumbers(double num)
{
    if (num == 0) return;
    Console.Write($"{num} ");
    NaturaleNumbers(num - 1);
}