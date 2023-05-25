// Напишет программу которая принмает на вход координаты двух точек и находит рассторяние между ними в 2D пространстве

Console.WriteLine("Введите Координаты точка A ");

Console.WriteLine("x = ");
int coordinatesX1 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("y = ");
int coordinatesY1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B ");

Console.WriteLine("x = ");
int coordinatesX2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("y = ");
int coordinatesY2 = Convert.ToInt32(Console.ReadLine());


double distance = Distance(coordinatesX1,coordinatesY1,coordinatesX2,coordinatesY2);

Console.WriteLine( Math.Round(distance,2,MidpointRounding.ToZero));


double Distance (int coordinatesX1, int coordinatesY1, int coordinatesX2, int coordinatesY2)
{
   
    int gipotin1 = coordinatesX2 - coordinatesX1;
   
    int gipotin2 = coordinatesY2 - coordinatesY1;

    int gipotin3 = gipotin1 * gipotin1 +  gipotin2 * gipotin2;

    double gip = Math.Sqrt(gipotin3);

        return gip;

}