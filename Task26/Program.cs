// Напишите программу которая принмает на вход число и выдает количество цифр в числе.

Console.WriteLine ("введите число");
int number= Convert.ToInt32(Console.ReadLine());

int quantiy = QuantityNum(number);

Console.WriteLine($"количество цифр в  {number} - > {quantiy}");

int QuantityNum(int num)
{
    int i =0;
    while (num!=0)
    {
        num = num/10;
        i++;
    }
    return i;
}