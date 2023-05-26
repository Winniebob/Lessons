// Напишите программу которая найдет точку пересечения двух прямых, заданных уравнением y = k1* x +b1, y = k2* x + b2

Console.WriteLine("b1 = ");
double b1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("k1 = ");
double k1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("b2 = ");
double b2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("k2 = ");
double k2 = Convert.ToInt32(Console.ReadLine());


double x = (b2 - b1)/(k1 - k2);
double y = k2 * x + b2;

Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}");