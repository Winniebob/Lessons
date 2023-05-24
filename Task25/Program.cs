// Напишите цикл , который принимает на вход два числа и возводит число A в натуральную степерь B

Console.WriteLine ("Введите число:");
int numberA= Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите натуральную степень:");
int numberB= Convert.ToInt32(Console.ReadLine());

int numberDegree = NumberDegree(numberA, numberB);

Console.WriteLine ($"Возведя в натуральную степерь {numberB} число {numberA} получаем -> {numberDegree}");

int NumberDegree(int numA,int numB)
{
    int degree =1;
    for (int i = 0; i < numB; i++)
    {
        degree = degree*numA;
    }
    return degree;
}
