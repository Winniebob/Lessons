// Напишите программу которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());

int secondNumber = number / 10 % 10;
Console.WriteLine($"Введенное число {number} ");
Console.WriteLine($"Вторая цифра {secondNumber} ");


    if (number<=100&&number>=1000)
    {
        Console.WriteLine($"Некорректный ввод");
    }
    return;
