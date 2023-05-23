// Нахождение четного не четного числа. При нахождении не четного вывод остатка.

Console.WriteLine("Введите число 1");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 2");
int number2 = Convert.ToInt32(Console.ReadLine());

int remained = Remained(number1,number2);

String result = remained != 0 ?$" Не кратное = {remained}" : "кратное" ;

Console.WriteLine(result);

int Remained (int num1, int num2)
{
    return num1 % num2;
}