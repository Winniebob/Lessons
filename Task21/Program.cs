// Напишите программу которая принимает координаты двух точек и находит расстояние между ними в пространстве 3 D

Console.WriteLine("Введите Координаты точка A ");

Console.WriteLine("x = ");
int X1 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("y = ");
int Y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Z = ");
int Z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B ");

Console.WriteLine("x = ");
int X2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("y = ");
int Y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Z = ");
int Z2 = Convert.ToInt32(Console.ReadLine());


double distatce = Distance(X1,Y1,Z1,X2,Y2,Z2);

Console.WriteLine(Math.Round(distatce,2,MidpointRounding.ToZero));

double Distance(int X1, int Y1,int Z1,int X2,int Y2,int Z2)
{
    double katet1 = X2-X1;
    double katet2 = Y2-Y1;
    double katet3 = Z1-Z2;
    double squart = Math.Sqrt(katet1*katet1+katet2*katet2+katet3*katet3);
    return squart;
}