// Нахождение четного не четного числа. При нахождении не четного вывод остатка.

Console.WriteLine("Введите число 1");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 2");
int number2 = Convert.ToInt32(Console.ReadLine());
int remainder = number1 % number2;
if ( remainder == 0)
{
    Console.WriteLine("кратное");
}
else 
{
    Console.WriteLine($" Не кратное = {remainder}");
}