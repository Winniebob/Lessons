// Напишите программу которая на вход принимает число и выдает, является ли число четным ( делится ли оно на два без остатка)
Console.WriteLine("Введите  число ");
int number = Convert.ToInt32(Console.ReadLine());
if ( number%2 == 0 ) // Знаносим в оператор if формулу определения четности числа
{
    Console.WriteLine($"{number} является четным числом");
}
else 
{
    Console.WriteLine($"{number} не является четным числом");
}