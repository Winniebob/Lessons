// Напишите программу, которая принимает на вход число (N) и выдает таблицу квадратов чисел от 1 до N;

Console.WriteLine (" введите число");
int numberN = Convert.ToInt32(Console.ReadLine());

Math(numberN);

void Math(int num)
{
    for (int i = 1; i <= num; i++) // Работаем с счетчиком , введеное число служит неявным стоп сигналом
    {
        int kvadrat = i*i;
        Console.WriteLine ($"{i,3} {kvadrat,5} ");
    }
}