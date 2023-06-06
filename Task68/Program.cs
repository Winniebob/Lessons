//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.


Console.Write("Введите натуральное число M: ");
double numberM = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите натуральное число N: ");
double numberN = Convert.ToDouble(Console.ReadLine());

if (numberN < 0 || numberN % 1 != 0)
{

    Console.Write("Это не натуральное число");
    return;
}

if (numberM < 0 || numberM % 1 != 0)
{

    Console.Write("Это не натуральное число");
    return;
}

double akkermanFunction = AkkermanFunction(numberM,numberN);
Console.WriteLine($"{akkermanFunction}");

double AkkermanFunction (double numberM, double numberN)
{
    if (numberM == 0 )
    return numberN+1;
    else if (numberN == 0 && numberM>0)
    return AkkermanFunction(numberM-1,1);
    else 
    return AkkermanFunction(numberM-1, AkkermanFunction(numberM,numberN-1));
}