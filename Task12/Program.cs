// Нахождение четного не четного числа. При нахождении не четного вывод остатка.

Console.WriteLine("Введите число 1");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 2");
int number2 = Convert.ToInt32(Console.ReadLine());

String result = remained != 0 ? "кратное" : $" Не кратное = {Remained}";

Console.WriteLine(result);

int remained = Remained(number1,number2);

int Remained (int num1, num2)
{
    int remained = num1 % num2;
    return  remained;
}