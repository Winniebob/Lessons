// Напишите программу которая на вход принимает одно число (N) а на выходе показывает все целые числа от -N до N

Console.WriteLine("Введите целое положительное число");
int number1 = Convert.ToInt32(Console.ReadLine());
int count = -number1; // где -number это число счетчика который мы применяем 

while ( count <= number1 )
{
   Console.Write ($"{count} ");
   count++;
}
