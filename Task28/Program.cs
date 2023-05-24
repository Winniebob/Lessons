// Напишите программу которая принмает на вход число N и выдает произведение чисел от 1 до N

Console.WriteLine ("введите число");
int number= Convert.ToInt32(Console.ReadLine());

int workNumber = WorkNubmer(number);

Console.WriteLine ($"произведение чисел от 1 до {number} -> {workNumber}");

int WorkNubmer(int num)
{
    int work = 1;
    for (int i = 1; i <= num; i++)
    {
        work = work*i;
    }
    return work;
}