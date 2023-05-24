// Напишите программу которая принимает на вход число и выдает сумму цифр в числе 

Console.WriteLine ("Введите число:");
int number= Convert.ToInt32(Console.ReadLine());

int sumNumb = SumNumb(number);

Console.WriteLine ($"Сумма цифр в числе {number} -> {sumNumb}");

int SumNumb(int num)
{
    int sumDigit =0;
    while (num>0)
    {
        sumDigit = num%10 + sumDigit;
        num = num/10;
    }
    return sumDigit;
}