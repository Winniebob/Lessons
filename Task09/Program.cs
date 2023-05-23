// напишите программу которая выводит случайное число из отрезка [10,99] и показать наибольшую цифру. 78 ->8

int number = new Random().Next(10,100); // Генерирует псевдослучайное число new Random().Next пишем + 1 так как не входит в диапозон к 99
Console.WriteLine($"Случайное число из отрезка 10-99 -> {number} ");
/*int firstDigit = number/10;
int secondDigit = number%10;
if ( firstDigit>secondDigit)
{
    Console.WriteLine($"Наибольшая цифра = {firstDigit} ");
}
else
{
    Console.WriteLine($"Наибольшая цифра = {secondDigit} ");
}
// Тернарный оператор ( условие ? выражение 1 :выражение 2)
int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
Console.WriteLine($"Наибольшая цифра = {maxDigit} ");*/

int maxDigit = MaxDigit(number);
Console.WriteLine($" Наибольшая цифра числа -> {maxDigit} ");

int MaxDigit (int num)
{
    int firstDigit = num/10;
    int secondDigit = num%10;
    int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
    return maxDigit;
}