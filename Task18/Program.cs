// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти ( х и у).

Console.WriteLine("Введите номер четверти ");
int quarter = Convert.ToInt32(Console.ReadLine());

int range = Range(quarter);

string result = range>0 ? $"Указанные номер четверти соотвтествуют диапазону -> {quarter}" : "Введены некорректные координаты";

Console.WriteLine(result);

int Range (int quarter)
{
    if (quarter ==1) 
    {
    Console.WriteLine("Диапозон от +X до +Y ");
        return 1;
    }

    if (quarter ==2) 
    {
        Console.WriteLine("Диапозон от -X до +Y ");
        return 2;
    }
    if (quarter ==3) 
    {
        Console.WriteLine("Диапозон от -X до -Y ");
        return 3;
    }
    if (quarter ==4) 
    {
        Console.WriteLine("Диапозон от +X до -Y ");
        return 4;
    }
    return 0;
}