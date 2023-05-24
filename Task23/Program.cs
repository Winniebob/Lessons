// Напишите программу, которая принмает на вход число (N) и выдает таблицу кубов числе от 1 до N


Console.WriteLine ("введите число");
int numberN = Convert.ToInt32(Console.ReadLine());

Cubos(numberN);

void Cubos(int num)
{
    for (int i = 1; i <= num; i++)
    {
        int cubos = i*i*i;
        Console.WriteLine ($"{i,3} {cubos,5} ");
    }
        
}