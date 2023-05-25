Console.WriteLine("Введите Координаты точка точек ");

Console.WriteLine("x = ");
int x = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("y = ");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Z = ");
int z = Convert.ToInt32(Console.ReadLine());

bool result = RuzTriangle(x,y,z);

Console.WriteLine (result ? $"Да это треугольник!" : "Это не треугольник");

bool RuzTriangle (int x, int y, int z)
{
    if( x < y + z && y < x + z && z < y + x )
    {
       return true;
    }
    return false;
  
}