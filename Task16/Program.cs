// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
Console.WriteLine("Введите число 1");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 2");
int number2 = Convert.ToInt32(Console.ReadLine());

bool result = Multiplicity(number1,number2);

Console.WriteLine (result ? $"да" : "нет");

bool Multiplicity(int num1,int num2)
{
    return num1==num2*num2 || num2==num1*num1;
}