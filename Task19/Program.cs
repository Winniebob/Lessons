// Напишите программу которая пинимает на вход пятизначное число и проверяет является ли оно палиндромом

Console.WriteLine ("введите пятизначное число");
int numberN = Convert.ToInt32(Console.ReadLine());

Polindrom(numberN);

void Polindrom (int num)
{
    if(num>=10000 & num<=100000)
    {
    int num1 = num/10000;
    Console.WriteLine ($"{num1}");
    int num2 = num/1000%10;
    Console.WriteLine ($"{num2}");
    int num3 = num/10%10;
    Console.WriteLine ($"{num3}");
    int num4 = num%10;
    Console.WriteLine ($"{num4}");
    if (num1==num4 & num2==num3)
    {
        Console.WriteLine ($"{num} -> Да");
    }
    else
    {
        Console.WriteLine ($"{num} -> Нет");
    }
    }
    else
    {
        Console.WriteLine(" Число не входит в диапозон");
    }
}