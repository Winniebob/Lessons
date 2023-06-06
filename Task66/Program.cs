// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N


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

double sumNaturalNumb = SumNaturalNumb(numberN,numberM);
Console.WriteLine($"{sumNaturalNumb}");

double SumNaturalNumb (double numN, double numM)
{
    
    if (numN == numM) return numN;
    else if (numN>numM) return  numN + SumNaturalNumb(numN - 1, numM);
    else return numM + SumNaturalNumb(numM - 1, numN);
}

