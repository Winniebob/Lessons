// Напишите програму которая принимает на входе трехзначное значение и на выходе показывает последнюю цифру этого числа. 456 -> 6

Console.WriteLine("Введите трехзначное число");
int number1 = Convert.ToInt32(Console.ReadLine());

if (number1>=100&&number1<=999)
{
int lastNumber = number1%10; // Выводим третье число 
Console.WriteLine($"Последнее цифра в числе {number1} = {lastNumber}");
}
else
{
     Console.WriteLine($"Некорректный ввод");
}
