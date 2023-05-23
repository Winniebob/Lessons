// Напишите программу которая на вход принимает два числа и выает какое число больше, а какое меньше. a=5 b =7 -> max=7


Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());

if ( number1 > number2 )
{   
Console.WriteLine($"большее число это {number1} меньшее {number2}");
}
else
{
Console.WriteLine($"большее число это {number2} меньшее {number1}");
}
