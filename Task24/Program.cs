// Напишите программу которая принимает на вход число (A) и выдает сумму чисел от 1 до А


Console.WriteLine ("введите число");
int number= Convert.ToInt32(Console.ReadLine());

int sumNum = SumNum(number);

 Console.WriteLine($"Сумма чисел {number} - > {sumNum}");

int SumNum(int num)
{   
    int sum = 0;
    for (int i = 1; i <= num; i++)   
    {
        sum = sum + i;
    }
    return sum;
}